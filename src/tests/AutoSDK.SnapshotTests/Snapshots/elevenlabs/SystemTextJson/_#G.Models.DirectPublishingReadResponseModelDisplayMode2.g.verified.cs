//HintName: G.Models.DirectPublishingReadResponseModelDisplayMode2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DirectPublishingReadResponseModelDisplayMode2
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
    public static class DirectPublishingReadResponseModelDisplayMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectPublishingReadResponseModelDisplayMode2 value)
        {
            return value switch
            {
                DirectPublishingReadResponseModelDisplayMode2.AudioOnly => "audio-only",
                DirectPublishingReadResponseModelDisplayMode2.Text => "text",
                DirectPublishingReadResponseModelDisplayMode2.TextWithAudio => "text-with-audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectPublishingReadResponseModelDisplayMode2? ToEnum(string value)
        {
            return value switch
            {
                "audio-only" => DirectPublishingReadResponseModelDisplayMode2.AudioOnly,
                "text" => DirectPublishingReadResponseModelDisplayMode2.Text,
                "text-with-audio" => DirectPublishingReadResponseModelDisplayMode2.TextWithAudio,
                _ => null,
            };
        }
    }
}