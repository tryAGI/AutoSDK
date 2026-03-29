//HintName: G.Models.ImageSearchSafesearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: moderate
    /// </summary>
    public enum ImageSearchSafesearch
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
    public static class ImageSearchSafesearchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageSearchSafesearch value)
        {
            return value switch
            {
                ImageSearchSafesearch.Moderate => "moderate",
                ImageSearchSafesearch.Off => "off",
                ImageSearchSafesearch.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageSearchSafesearch? ToEnum(string value)
        {
            return value switch
            {
                "moderate" => ImageSearchSafesearch.Moderate,
                "off" => ImageSearchSafesearch.Off,
                "strict" => ImageSearchSafesearch.Strict,
                _ => null,
            };
        }
    }
}