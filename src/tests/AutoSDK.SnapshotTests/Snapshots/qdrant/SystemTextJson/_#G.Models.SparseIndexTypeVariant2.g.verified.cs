//HintName: G.Models.SparseIndexTypeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Immutable RAM sparse index
    /// </summary>
    public enum SparseIndexTypeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        ImmutableRam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SparseIndexTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SparseIndexTypeVariant2 value)
        {
            return value switch
            {
                SparseIndexTypeVariant2.ImmutableRam => "ImmutableRam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SparseIndexTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "ImmutableRam" => SparseIndexTypeVariant2.ImmutableRam,
                _ => null,
            };
        }
    }
}