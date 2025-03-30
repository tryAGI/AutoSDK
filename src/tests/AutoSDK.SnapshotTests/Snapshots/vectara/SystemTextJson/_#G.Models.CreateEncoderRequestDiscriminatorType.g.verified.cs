//HintName: G.Models.CreateEncoderRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateEncoderRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        OpenaiCompatible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEncoderRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEncoderRequestDiscriminatorType value)
        {
            return value switch
            {
                CreateEncoderRequestDiscriminatorType.OpenaiCompatible => "openai-compatible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEncoderRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "openai-compatible" => CreateEncoderRequestDiscriminatorType.OpenaiCompatible,
                _ => null,
            };
        }
    }
}