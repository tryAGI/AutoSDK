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
        /// <summary>
        /// 
        /// </summary>
        OpenaiResponses,
        /// <summary>
        /// 
        /// </summary>
        VertexAi,
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
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
                CreateLLMRequestDiscriminatorType.OpenaiResponses => "openai-responses",
                CreateLLMRequestDiscriminatorType.VertexAi => "vertex-ai",
                CreateLLMRequestDiscriminatorType.Anthropic => "anthropic",
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
                "openai-responses" => CreateLLMRequestDiscriminatorType.OpenaiResponses,
                "vertex-ai" => CreateLLMRequestDiscriminatorType.VertexAi,
                "anthropic" => CreateLLMRequestDiscriminatorType.Anthropic,
                _ => null,
            };
        }
    }
}