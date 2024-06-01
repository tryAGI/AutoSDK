//HintName: G.Models.SearchCommitsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum SearchCommitsOrder
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
    public static class SearchCommitsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchCommitsOrder value)
        {
            return value switch
            {
                SearchCommitsOrder.Desc => "desc",
                SearchCommitsOrder.Asc => "asc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchCommitsOrder ToEnum(string value)
        {
            return value switch
            {
                "desc" => SearchCommitsOrder.Desc,
                "asc" => SearchCommitsOrder.Asc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}