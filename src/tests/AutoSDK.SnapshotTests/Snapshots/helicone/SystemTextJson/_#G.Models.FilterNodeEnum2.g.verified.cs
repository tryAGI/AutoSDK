//HintName: G.Models.FilterNodeEnum2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FilterNodeEnum2
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterNodeEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterNodeEnum2 value)
        {
            return value switch
            {
                FilterNodeEnum2.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterNodeEnum2? ToEnum(string value)
        {
            return value switch
            {
                "all" => FilterNodeEnum2.All,
                _ => null,
            };
        }
    }
}