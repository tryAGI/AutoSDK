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
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
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
                SearchCodeOrder.Asc => "asc",
                SearchCodeOrder.Desc => "desc",
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
                "asc" => SearchCodeOrder.Asc,
                "desc" => SearchCodeOrder.Desc,
                _ => null,
            };
        }
    }
}