//HintName: G.Models.SearchCommitsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum SearchCommitsOrder
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
    public static class SearchCommitsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchCommitsOrder value)
        {
            return value switch
            {
                SearchCommitsOrder.Asc => "asc",
                SearchCommitsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchCommitsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => SearchCommitsOrder.Asc,
                "desc" => SearchCommitsOrder.Desc,
                _ => null,
            };
        }
    }
}