//HintName: G.Models.CreateLLMRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateLLMRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        OpenaiCompatible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateLLMRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLLMRequestDiscriminatorType value)
        {
            return value switch
            {
                CreateLLMRequestDiscriminatorType.OpenaiCompatible => "openai-compatible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLLMRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "openai-compatible" => CreateLLMRequestDiscriminatorType.OpenaiCompatible,
                _ => null,
            };
        }
    }
}