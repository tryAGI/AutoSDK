//HintName: G.Models.DirectPublishingReadResponseModelDisplayMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DirectPublishingReadResponseModelDisplayMode
    {
        /// <summary>
        /// 
        /// </summary>
        AudioOnly,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        TextWithAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectPublishingReadResponseModelDisplayModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectPublishingReadResponseModelDisplayMode value)
        {
            return value switch
            {
                DirectPublishingReadResponseModelDisplayMode.AudioOnly => "audio-only",
                DirectPublishingReadResponseModelDisplayMode.Text => "text",
                DirectPublishingReadResponseModelDisplayMode.TextWithAudio => "text-with-audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectPublishingReadResponseModelDisplayMode? ToEnum(string value)
        {
            return value switch
            {
                "audio-only" => DirectPublishingReadResponseModelDisplayMode.AudioOnly,
                "text" => DirectPublishingReadResponseModelDisplayMode.Text,
                "text-with-audio" => DirectPublishingReadResponseModelDisplayMode.TextWithAudio,
                _ => null,
            };
        }
    }
}