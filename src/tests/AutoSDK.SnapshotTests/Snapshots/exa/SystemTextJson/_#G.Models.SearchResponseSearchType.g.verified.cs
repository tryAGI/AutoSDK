//HintName: G.Models.SearchResponseSearchType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// For auto searches, indicates which search type was selected.<br/>
    /// Example: auto
    /// </summary>
    public enum SearchResponseSearchType
    {
        /// <summary>
        /// 
        /// </summary>
        Deep,
        /// <summary>
        /// 
        /// </summary>
        Neural,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchResponseSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResponseSearchType value)
        {
            return value switch
            {
                SearchResponseSearchType.Deep => "deep",
                SearchResponseSearchType.Neural => "neural",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResponseSearchType? ToEnum(string value)
        {
            return value switch
            {
                "deep" => SearchResponseSearchType.Deep,
                "neural" => SearchResponseSearchType.Neural,
                _ => null,
            };
        }
    }
}