//HintName: G.Models.DirectPublishingReadResponseModelDisplayMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DirectPublishingReadResponseModelDisplayMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio-only")]
        AudioOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-with-audio")]
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