//HintName: G.Models.UpdateLLMRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateLLMRequestDiscriminatorType
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
    public static class UpdateLLMRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateLLMRequestDiscriminatorType value)
        {
            return value switch
            {
                UpdateLLMRequestDiscriminatorType.OpenaiCompatible => "openai-compatible",
                UpdateLLMRequestDiscriminatorType.OpenaiResponses => "openai-responses",
                UpdateLLMRequestDiscriminatorType.VertexAi => "vertex-ai",
                UpdateLLMRequestDiscriminatorType.Anthropic => "anthropic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateLLMRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "openai-compatible" => UpdateLLMRequestDiscriminatorType.OpenaiCompatible,
                "openai-responses" => UpdateLLMRequestDiscriminatorType.OpenaiResponses,
                "vertex-ai" => UpdateLLMRequestDiscriminatorType.VertexAi,
                "anthropic" => UpdateLLMRequestDiscriminatorType.Anthropic,
                _ => null,
            };
        }
    }
}