//HintName: G.Models.StudioClipReferenceClipType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StudioClipReferenceClipType
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        ExternalAudio,
        /// <summary>
        /// 
        /// </summary>
        TtsNode,
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
                StudioClipReferenceClipType.Video => "video",
                StudioClipReferenceClipType.Image => "image",
                StudioClipReferenceClipType.ExternalAudio => "external_audio",
                StudioClipReferenceClipType.TtsNode => "tts_node",
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
                "video" => StudioClipReferenceClipType.Video,
                "image" => StudioClipReferenceClipType.Image,
                "external_audio" => StudioClipReferenceClipType.ExternalAudio,
                "tts_node" => StudioClipReferenceClipType.TtsNode,
                _ => null,
            };
        }
    }
}