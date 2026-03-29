//HintName: G.Models.VectorStorageTypeVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Same as `ChunkedMmap`, but vectors are forced to be locked in RAM In this way we avoid cold requests to disk, but risk to run out of memory<br/>
    /// Designed as a replacement for `Memory`, which doesn't depend on RocksDB
    /// </summary>
    public enum VectorStorageTypeVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        InRamChunkedMmap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStorageTypeVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStorageTypeVariant4 value)
        {
            return value switch
            {
                VectorStorageTypeVariant4.InRamChunkedMmap => "InRamChunkedMmap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStorageTypeVariant4? ToEnum(string value)
        {
            return value switch
            {
                "InRamChunkedMmap" => VectorStorageTypeVariant4.InRamChunkedMmap,
                _ => null,
            };
        }
    }
}