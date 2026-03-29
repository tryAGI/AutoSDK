//HintName: G.Models.SparseIndexTypeVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Mmap sparse index
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SparseIndexTypeVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mmap")]
        Mmap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SparseIndexTypeVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SparseIndexTypeVariant3 value)
        {
            return value switch
            {
                SparseIndexTypeVariant3.Mmap => "Mmap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SparseIndexTypeVariant3? ToEnum(string value)
        {
            return value switch
            {
                "Mmap" => SparseIndexTypeVariant3.Mmap,
                _ => null,
            };
        }
    }
}