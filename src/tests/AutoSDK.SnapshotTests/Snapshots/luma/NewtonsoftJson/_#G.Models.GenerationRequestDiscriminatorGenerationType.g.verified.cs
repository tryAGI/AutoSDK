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
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
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
                GenerationRequestDiscriminatorGenerationType.Image => "image",
                GenerationRequestDiscriminatorGenerationType.Video => "video",
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
                "image" => GenerationRequestDiscriminatorGenerationType.Image,
                "video" => GenerationRequestDiscriminatorGenerationType.Video,
                _ => null,
            };
        }
    }
}