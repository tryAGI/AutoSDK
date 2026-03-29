//HintName: G.Models.MediaContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: media
    /// </summary>
    public enum MediaContentType
    {
        /// <summary>
        /// 
        /// </summary>
        Media,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MediaContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MediaContentType value)
        {
            return value switch
            {
                MediaContentType.Media => "media",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MediaContentType? ToEnum(string value)
        {
            return value switch
            {
                "media" => MediaContentType.Media,
                _ => null,
            };
        }
    }
}