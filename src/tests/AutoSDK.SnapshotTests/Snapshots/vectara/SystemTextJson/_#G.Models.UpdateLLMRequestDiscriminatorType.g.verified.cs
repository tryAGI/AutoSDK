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
        Anthropic,
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
                UpdateLLMRequestDiscriminatorType.Anthropic => "anthropic",
                UpdateLLMRequestDiscriminatorType.OpenaiCompatible => "openai-compatible",
                UpdateLLMRequestDiscriminatorType.OpenaiResponses => "openai-responses",
                UpdateLLMRequestDiscriminatorType.VertexAi => "vertex-ai",
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
                "anthropic" => UpdateLLMRequestDiscriminatorType.Anthropic,
                "openai-compatible" => UpdateLLMRequestDiscriminatorType.OpenaiCompatible,
                "openai-responses" => UpdateLLMRequestDiscriminatorType.OpenaiResponses,
                "vertex-ai" => UpdateLLMRequestDiscriminatorType.VertexAi,
                _ => null,
            };
        }
    }
}