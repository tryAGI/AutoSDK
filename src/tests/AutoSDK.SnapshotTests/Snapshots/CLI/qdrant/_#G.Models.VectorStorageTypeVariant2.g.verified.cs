//HintName: G.Models.VectorStorageTypeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Storage in mmap file, not appendable<br/>
    /// Search performance is defined by disk speed and the fraction of vectors that fit in memory.
    /// </summary>
    public enum VectorStorageTypeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Mmap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStorageTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStorageTypeVariant2 value)
        {
            return value switch
            {
                VectorStorageTypeVariant2.Mmap => "Mmap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStorageTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "Mmap" => VectorStorageTypeVariant2.Mmap,
                _ => null,
            };
        }
    }
}