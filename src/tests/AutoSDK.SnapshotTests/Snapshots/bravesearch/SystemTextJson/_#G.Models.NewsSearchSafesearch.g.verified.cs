//HintName: G.Models.NewsSearchSafesearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: moderate
    /// </summary>
    public enum NewsSearchSafesearch
    {
        /// <summary>
        /// 
        /// </summary>
        Moderate,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        Strict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewsSearchSafesearchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewsSearchSafesearch value)
        {
            return value switch
            {
                NewsSearchSafesearch.Moderate => "moderate",
                NewsSearchSafesearch.Off => "off",
                NewsSearchSafesearch.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewsSearchSafesearch? ToEnum(string value)
        {
            return value switch
            {
                "moderate" => NewsSearchSafesearch.Moderate,
                "off" => NewsSearchSafesearch.Off,
                "strict" => NewsSearchSafesearch.Strict,
                _ => null,
            };
        }
    }
}