//HintName: G.Models.SparseIndexTypeVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Mutable RAM sparse index
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SparseIndexTypeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MutableRam")]
        MutableRam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SparseIndexTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SparseIndexTypeVariant1 value)
        {
            return value switch
            {
                SparseIndexTypeVariant1.MutableRam => "MutableRam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SparseIndexTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "MutableRam" => SparseIndexTypeVariant1.MutableRam,
                _ => null,
            };
        }
    }
}