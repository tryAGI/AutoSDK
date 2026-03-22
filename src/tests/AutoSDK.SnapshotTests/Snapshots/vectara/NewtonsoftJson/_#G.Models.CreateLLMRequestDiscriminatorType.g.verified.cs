//HintName: G.Models.CreateLLMRequestDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateLLMRequestDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic")]
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-compatible")]
        OpenaiCompatible,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai-responses")]
        OpenaiResponses,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vertex-ai")]
        VertexAi,
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
                CreateLLMRequestDiscriminatorType.Anthropic => "anthropic",
                CreateLLMRequestDiscriminatorType.OpenaiCompatible => "openai-compatible",
                CreateLLMRequestDiscriminatorType.OpenaiResponses => "openai-responses",
                CreateLLMRequestDiscriminatorType.VertexAi => "vertex-ai",
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
                "anthropic" => CreateLLMRequestDiscriminatorType.Anthropic,
                "openai-compatible" => CreateLLMRequestDiscriminatorType.OpenaiCompatible,
                "openai-responses" => CreateLLMRequestDiscriminatorType.OpenaiResponses,
                "vertex-ai" => CreateLLMRequestDiscriminatorType.VertexAi,
                _ => null,
            };
        }
    }
}