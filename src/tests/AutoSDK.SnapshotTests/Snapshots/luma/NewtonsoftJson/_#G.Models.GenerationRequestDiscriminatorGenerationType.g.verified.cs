//HintName: G.Models.GenerationRequestDiscriminatorGenerationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GenerationRequestDiscriminatorGenerationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
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