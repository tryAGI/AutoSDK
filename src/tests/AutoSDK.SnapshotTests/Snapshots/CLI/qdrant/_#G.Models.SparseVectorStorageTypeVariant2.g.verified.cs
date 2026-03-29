//HintName: G.Models.SparseVectorStorageTypeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Storage in memory maps (gridstore storage)
    /// </summary>
    public enum SparseVectorStorageTypeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Mmap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SparseVectorStorageTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SparseVectorStorageTypeVariant2 value)
        {
            return value switch
            {
                SparseVectorStorageTypeVariant2.Mmap => "mmap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SparseVectorStorageTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "mmap" => SparseVectorStorageTypeVariant2.Mmap,
                _ => null,
            };
        }
    }
}