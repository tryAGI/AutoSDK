//HintName: G.Models.VectorStorageTypeVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Storage in chunked mmap files, appendable<br/>
    /// Search performance is defined by disk speed and the fraction of vectors that fit in memory.
    /// </summary>
    public enum VectorStorageTypeVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        ChunkedMmap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStorageTypeVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStorageTypeVariant3 value)
        {
            return value switch
            {
                VectorStorageTypeVariant3.ChunkedMmap => "ChunkedMmap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStorageTypeVariant3? ToEnum(string value)
        {
            return value switch
            {
                "ChunkedMmap" => VectorStorageTypeVariant3.ChunkedMmap,
                _ => null,
            };
        }
    }
}