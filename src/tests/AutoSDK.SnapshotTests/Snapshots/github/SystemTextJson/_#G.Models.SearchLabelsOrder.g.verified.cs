//HintName: G.Models.SearchLabelsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum SearchLabelsOrder
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
    public static class SearchLabelsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchLabelsOrder value)
        {
            return value switch
            {
                SearchLabelsOrder.Asc => "asc",
                SearchLabelsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchLabelsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => SearchLabelsOrder.Asc,
                "desc" => SearchLabelsOrder.Desc,
                _ => null,
            };
        }
    }
}