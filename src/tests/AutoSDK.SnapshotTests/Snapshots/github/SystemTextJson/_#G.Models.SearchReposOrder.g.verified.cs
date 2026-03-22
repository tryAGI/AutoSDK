//HintName: G.Models.SearchReposOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum SearchReposOrder
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
    public static class SearchReposOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchReposOrder value)
        {
            return value switch
            {
                SearchReposOrder.Asc => "asc",
                SearchReposOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchReposOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => SearchReposOrder.Asc,
                "desc" => SearchReposOrder.Desc,
                _ => null,
            };
        }
    }
}