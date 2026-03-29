//HintName: G.Models.VideoSearchSafesearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: moderate
    /// </summary>
    public enum VideoSearchSafesearch
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
    public static class VideoSearchSafesearchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoSearchSafesearch value)
        {
            return value switch
            {
                VideoSearchSafesearch.Moderate => "moderate",
                VideoSearchSafesearch.Off => "off",
                VideoSearchSafesearch.Strict => "strict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoSearchSafesearch? ToEnum(string value)
        {
            return value switch
            {
                "moderate" => VideoSearchSafesearch.Moderate,
                "off" => VideoSearchSafesearch.Off,
                "strict" => VideoSearchSafesearch.Strict,
                _ => null,
            };
        }
    }
}