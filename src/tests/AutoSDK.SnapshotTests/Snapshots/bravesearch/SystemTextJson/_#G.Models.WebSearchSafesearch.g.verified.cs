//HintName: G.Models.WebSearchSafesearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: moderate
    /// </summary>
    public enum WebSearchSafesearch
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
    public static class WebSearchSafesearchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchSafesearch value)
        {
            return value switch
            {
                WebSearchSafesearch.Moderate => "moderate",
                WebSearchSafesearch.Off => "off",
                WebSearchSafesearch.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchSafesearch? ToEnum(string value)
        {
            return value switch
            {
                "moderate" => WebSearchSafesearch.Moderate,
                "off" => WebSearchSafesearch.Off,
                "strict" => WebSearchSafesearch.Strict,
                _ => null,
            };
        }
    }
}