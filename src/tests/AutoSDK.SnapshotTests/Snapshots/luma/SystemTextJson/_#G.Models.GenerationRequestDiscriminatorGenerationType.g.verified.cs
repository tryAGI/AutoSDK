//HintName: G.Models.GenerationRequestDiscriminatorGenerationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerationRequestDiscriminatorGenerationType
    {
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationRequestDiscriminatorGenerationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationRequestDiscriminatorGenerationType value)
        {
            return value switch
            {
                GenerationRequestDiscriminatorGenerationType.Video => "video",
                GenerationRequestDiscriminatorGenerationType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationRequestDiscriminatorGenerationType? ToEnum(string value)
        {
            return value switch
            {
                "video" => GenerationRequestDiscriminatorGenerationType.Video,
                "image" => GenerationRequestDiscriminatorGenerationType.Image,
                _ => null,
            };
        }
    }
}