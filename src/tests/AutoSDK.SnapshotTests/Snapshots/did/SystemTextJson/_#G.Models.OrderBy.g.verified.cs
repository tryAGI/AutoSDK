//HintName: G.Models.OrderBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrderBy
    {
        /// <summary>
        /// 
        /// </summary>
        Ascending,
        /// <summary>
        /// 
        /// </summary>
        Descending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrderBy value)
        {
            return value switch
            {
                OrderBy.Ascending => "ascending",
                OrderBy.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrderBy? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => OrderBy.Ascending,
                "descending" => OrderBy.Descending,
                _ => null,
            };
        }
    }
}