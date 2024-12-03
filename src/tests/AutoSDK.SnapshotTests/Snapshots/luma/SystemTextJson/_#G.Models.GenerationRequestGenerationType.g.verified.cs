//HintName: G.Models.GenerationRequestGenerationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: video
    /// </summary>
    public enum GenerationRequestGenerationType
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationRequestGenerationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationRequestGenerationType value)
        {
            return value switch
            {
                GenerationRequestGenerationType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationRequestGenerationType? ToEnum(string value)
        {
            return value switch
            {
                "video" => GenerationRequestGenerationType.Video,
                _ => null,
            };
        }
    }
}