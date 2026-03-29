//HintName: G.Models.MediaFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Format of the media data.<br/>
    /// Default Value: neither
    /// </summary>
    public enum MediaFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        Neither,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MediaFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MediaFormat value)
        {
            return value switch
            {
                MediaFormat.Base64 => "base64",
                MediaFormat.Neither => "neither",
                MediaFormat.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MediaFormat? ToEnum(string value)
        {
            return value switch
            {
                "base64" => MediaFormat.Base64,
                "neither" => MediaFormat.Neither,
                "url" => MediaFormat.Url,
                _ => null,
            };
        }
    }
}