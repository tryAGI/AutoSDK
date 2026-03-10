//HintName: G.Models.DirectPublishingReadResponseModelDisplayMode2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DirectPublishingReadResponseModelDisplayMode2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio-only")]
        AudioOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-with-audio")]
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
                DirectPublishingReadResponseModelDisplayMode2.Text => "text",
                DirectPublishingReadResponseModelDisplayMode2.AudioOnly => "audio-only",
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
                "text" => DirectPublishingReadResponseModelDisplayMode2.Text,
                "audio-only" => DirectPublishingReadResponseModelDisplayMode2.AudioOnly,
                "text-with-audio" => DirectPublishingReadResponseModelDisplayMode2.TextWithAudio,
                _ => null,
            };
        }
    }
}