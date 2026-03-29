//HintName: G.Models.SearchAllMessagesRequestSearchMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Search mode to use<br/>
    /// Default Value: hybrid
    /// </summary>
    public enum SearchAllMessagesRequestSearchMode
    {
        /// <summary>
        /// 
        /// </summary>
        Fts,
        /// <summary>
        /// 
        /// </summary>
        Hybrid,
        /// <summary>
        /// 
        /// </summary>
        Vector,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchAllMessagesRequestSearchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchAllMessagesRequestSearchMode value)
        {
            return value switch
            {
                SearchAllMessagesRequestSearchMode.Fts => "fts",
                SearchAllMessagesRequestSearchMode.Hybrid => "hybrid",
                SearchAllMessagesRequestSearchMode.Vector => "vector",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchAllMessagesRequestSearchMode? ToEnum(string value)
        {
            return value switch
            {
                "fts" => SearchAllMessagesRequestSearchMode.Fts,
                "hybrid" => SearchAllMessagesRequestSearchMode.Hybrid,
                "vector" => SearchAllMessagesRequestSearchMode.Vector,
                _ => null,
            };
        }
    }
}