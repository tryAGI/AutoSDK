//HintName: G.Models.ModelCapability.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelCapability
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Caching,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Reasoning,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelCapabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelCapability value)
        {
            return value switch
            {
                ModelCapability.Audio => "audio",
                ModelCapability.Caching => "caching",
                ModelCapability.Image => "image",
                ModelCapability.Reasoning => "reasoning",
                ModelCapability.Thinking => "thinking",
                ModelCapability.Video => "video",
                ModelCapability.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelCapability? ToEnum(string value)
        {
            return value switch
            {
                "audio" => ModelCapability.Audio,
                "caching" => ModelCapability.Caching,
                "image" => ModelCapability.Image,
                "reasoning" => ModelCapability.Reasoning,
                "thinking" => ModelCapability.Thinking,
                "video" => ModelCapability.Video,
                "web_search" => ModelCapability.WebSearch,
                _ => null,
            };
        }
    }
}