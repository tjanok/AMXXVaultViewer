using System;
using System.Collections.Generic;
using DarkUI.Forms;
using DarkUI.Controls;
using System.IO;

namespace AMXXVaultViewer
{
    class VaultFile
    {
        // NVault.h
        // https://github.com/alliedmodders/amxmodx/blob/master/modules/nvault/NVault.h

        public ushort   VAULT_VERSION       = 0x0200;
        public uint     VAULT_MAGIC         = 0x6E564C54;

        VaultEntry selectedEntry;
        Dictionary<VaultEntry, String> keyValues = new Dictionary<VaultEntry, String>();

        public int NumberOfEntries()
        {
            return keyValues.Count;
        }

        public void SetValue( String value )
        {
            keyValues[selectedEntry] = value;
        }

        public String GetValue()
        {
            return keyValues[selectedEntry];
        }

        public VaultEntry SelectedEntry
        {
            get { return selectedEntry; }
            set { selectedEntry = value; }
        }

        public void PopulateListView( DarkListView lv )
        {
            foreach( KeyValuePair<VaultEntry,String> entry in keyValues )
            {
                DarkListItem item = new DarkListItem( entry.Key.key );
                item.Tag = entry.Key;
                lv.Items.Add( item );
            }
        }

        public static DateTime ConvertFromUnixTime( UInt32 timestamp )
        {
            return new DateTime( 1970, 1, 1 ).ToLocalTime().AddSeconds( timestamp );
        }

        public static UInt32 ConvertFromDateTime( DateTime timestamp )
        {
            return (UInt32)( timestamp.ToLocalTime().Subtract( new DateTime( 1970, 1, 1 ) ) ).TotalSeconds;
        }

        public bool Open( String file )
        {
            try
            {
                BinaryReader br = new BinaryReader( File.Open( file, FileMode.Open ) );
                VaultFileHeader header;

                if( br != null )
                {
                    header.magic = br.ReadUInt32();

                    if( header.magic != VAULT_MAGIC )
                        return false;

                    header.version = br.ReadUInt16();
                    if( header.version != VAULT_VERSION )
                        return false;

                    header.entries = br.ReadUInt32();

                    UInt32 temp;
                    Byte keyLen;
                    UInt16 valueLen;

                    for( int i = 0; i < header.entries; i++ )
                    {
                        //timestamp
                        //C++ time_t
                        temp = br.ReadUInt32();
                        keyLen = br.ReadByte();
                        valueLen = br.ReadUInt16();

                        char[] key = br.ReadChars( keyLen );
                        char[] value = br.ReadChars( valueLen );

                        VaultEntry entry = new VaultEntry();
                        entry.key = new string( key );
                        entry.timestamp = ConvertFromUnixTime( temp );

                        keyValues.Add( entry, new string( value ) );
                    }

                    br.Close();
                    return true;
                }
            }
            catch( Exception e )
            {
                return false;
            }
            return false;
        }
    }
}
