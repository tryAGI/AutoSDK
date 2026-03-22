//HintName: G.Models.StudioClipReferenceClipType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StudioClipReferenceClipType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="external_audio")]
        ExternalAudio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tts_node")]
        TtsNode,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StudioClipReferenceClipTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StudioClipReferenceClipType value)
        {
            return value switch
            {
                StudioClipReferenceClipType.ExternalAudio => "external_audio",
                StudioClipReferenceClipType.Image => "image",
                StudioClipReferenceClipType.TtsNode => "tts_node",
                StudioClipReferenceClipType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StudioClipReferenceClipType? ToEnum(string value)
        {
            return value switch
            {
                "external_audio" => StudioClipReferenceClipType.ExternalAudio,
                "image" => StudioClipReferenceClipType.Image,
                "tts_node" => StudioClipReferenceClipType.TtsNode,
                "video" => StudioClipReferenceClipType.Video,
                _ => null,
            };
        }
    }
}