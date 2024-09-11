//HintName: G.Models.OrderBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum OrderBy
    {
        /// <summary>
        /// 
        /// </summary>
        Popular,
        /// <summary>
        /// 
        /// </summary>
        Recent,
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
                OrderBy.Popular => "popular",
                OrderBy.Recent => "recent",
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
                "popular" => OrderBy.Popular,
                "recent" => OrderBy.Recent,
                _ => null,
            };
        }
    }
}