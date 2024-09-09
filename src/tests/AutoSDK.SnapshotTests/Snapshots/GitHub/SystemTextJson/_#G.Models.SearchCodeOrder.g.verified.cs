//HintName: G.Models.SearchCodeOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum SearchCodeOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Desc,
        /// <summary>
        /// 
        /// </summary>
        Asc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchCodeOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchCodeOrder value)
        {
            return value switch
            {
                SearchCodeOrder.Desc => "desc",
                SearchCodeOrder.Asc => "asc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchCodeOrder? ToEnum(string value)
        {
            return value switch
            {
                "desc" => SearchCodeOrder.Desc,
                "asc" => SearchCodeOrder.Asc,
                _ => null,
            };
        }
    }
}