//HintName: G.Models.ValidatePayloadLlmApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The LLM API to use for validation
    /// </summary>
    public enum ValidatePayloadLlmApi
    {
        /// <summary>
        /// 
        /// </summary>
        LitellmAcompletion,
        /// <summary>
        /// 
        /// </summary>
        LitellmCompletion,
        /// <summary>
        /// 
        /// </summary>
        OpenaiChatCompletionAcreate,
        /// <summary>
        /// 
        /// </summary>
        OpenaiChatCompletionCreate,
        /// <summary>
        /// 
        /// </summary>
        OpenaiCompletionAcreate,
        /// <summary>
        /// 
        /// </summary>
        OpenaiCompletionCreate,
        /// <summary>
        /// 
        /// </summary>
        OpenaiChatCompletionsCreate,
        /// <summary>
        /// 
        /// </summary>
        OpenaiCompletionsCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValidatePayloadLlmApiExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValidatePayloadLlmApi value)
        {
            return value switch
            {
                ValidatePayloadLlmApi.LitellmAcompletion => "litellm.acompletion",
                ValidatePayloadLlmApi.LitellmCompletion => "litellm.completion",
                ValidatePayloadLlmApi.OpenaiChatCompletionAcreate => "openai.ChatCompletion.acreate",
                ValidatePayloadLlmApi.OpenaiChatCompletionCreate => "openai.ChatCompletion.create",
                ValidatePayloadLlmApi.OpenaiCompletionAcreate => "openai.Completion.acreate",
                ValidatePayloadLlmApi.OpenaiCompletionCreate => "openai.Completion.create",
                ValidatePayloadLlmApi.OpenaiChatCompletionsCreate => "openai.chat.completions.create",
                ValidatePayloadLlmApi.OpenaiCompletionsCreate => "openai.completions.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValidatePayloadLlmApi? ToEnum(string value)
        {
            return value switch
            {
                "litellm.acompletion" => ValidatePayloadLlmApi.LitellmAcompletion,
                "litellm.completion" => ValidatePayloadLlmApi.LitellmCompletion,
                "openai.ChatCompletion.acreate" => ValidatePayloadLlmApi.OpenaiChatCompletionAcreate,
                "openai.ChatCompletion.create" => ValidatePayloadLlmApi.OpenaiChatCompletionCreate,
                "openai.Completion.acreate" => ValidatePayloadLlmApi.OpenaiCompletionAcreate,
                "openai.Completion.create" => ValidatePayloadLlmApi.OpenaiCompletionCreate,
                "openai.chat.completions.create" => ValidatePayloadLlmApi.OpenaiChatCompletionsCreate,
                "openai.completions.create" => ValidatePayloadLlmApi.OpenaiCompletionsCreate,
                _ => null,
            };
        }
    }
}