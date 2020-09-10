using System;
using System.Collections.Generic;

namespace AMXXVaultViewer
{
    public struct VaultFileHeader
    {
        public UInt32 magic;
        public UInt16 version;
        public UInt32 entries;
    }
}