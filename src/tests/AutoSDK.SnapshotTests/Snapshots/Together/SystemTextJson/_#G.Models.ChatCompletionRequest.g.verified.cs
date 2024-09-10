//HintName: G.Models.ChatCompletionRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequest
    {
        /// <summary>
        /// A list of messages comprising the conversation so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChatCompletionRequestMessage> Messages { get; set; }

        /// <summary>
        /// The name of the model to query.<br/>
        /// Example: mistralai/Mixtral-8x7B-Instruct-v0.1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int MaxTokens { get; set; }

        /// <summary>
        /// A list of string sequences that will truncate (stop) inference text output. For example, "&lt;/s&gt;" will stop generation as soon as the model generates the given token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        /// A decimal number from 0-1 that determines the degree of randomness in the response. A temperature less than 1 favors more correctness and is appropriate for question answering or summarization. A value closer to 1 introduces more randomness in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float Temperature { get; set; }

        /// <summary>
        /// A percentage (also called the nucleus parameter) that's used to dynamically adjust the number of choices for each predicted token based on the cumulative probabilities. It specifies a probability threshold below which all less likely tokens are filtered out. This technique helps maintain diversity and generate more fluent and natural-sounding text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float TopP { get; set; }

        /// <summary>
        /// An integer that's used to limit the number of choices for the next predicted word or token. It specifies the maximum number of tokens to consider at each step, based on their probability of occurrence. This technique helps to speed up the generation process and can improve the quality of the generated text by focusing on the most likely options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int TopK { get; set; }

        /// <summary>
        /// A number that controls the diversity of generated text by reducing the likelihood of repeated sequences. Higher values decrease repetition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetition_penalty")]
        public double RepetitionPenalty { get; set; }

        /// <summary>
        /// If true, stream tokens as Server-Sent Events as the model generates them instead of waiting for the full model response. The stream terminates with `data: [DONE]`. If false, return a single JSON object containing the results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool Stream { get; set; }

        /// <summary>
        /// Determines the number of most likely tokens to return at each token position log probabilities to return.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public int Logprobs { get; set; }

        /// <summary>
        /// If true, the response will contain the prompt. Can be used with `logprobs` to return prompt logprobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("echo")]
        public bool Echo { get; set; }

        /// <summary>
        /// The number of completions to generate for each prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int N { get; set; }

        /// <summary>
        /// A number between 0 and 1 that can be used as an alternative to top_p and top-k.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_p")]
        public float MinP { get; set; }

        /// <summary>
        /// A number between -2.0 and 2.0 where a positive value increases the likelihood of a model talking about new topics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public float PresencePenalty { get; set; }

        /// <summary>
        /// A number between -2.0 and 2.0 where a positive value decreases the likelihood of repeating tokens that have already been mentioned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public float FrequencyPenalty { get; set; }

        /// <summary>
        /// Adjusts the likelihood of specific tokens appearing in the generated output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::G.ChatCompletionRequestLogitBias? LogitBias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<global::G.ChatCompletionRequestFunctionCallEnum?, global::G.ChatCompletionRequestFunctionCallEnum2>? FunctionCall { get; set; }

        /// <summary>
        /// An object specifying the format that the model must output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::G.ChatCompletionRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.ToolsPart>? Tools { get; set; }

        /// <summary>
        /// Controls which (if any) function is called by the model. By default uses `auto`, which lets the model pick between generating a message or calling a function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        public global::G.OneOf<string, global::G.ToolChoice2>? ToolChoice { get; set; }

        /// <summary>
        /// The name of the moderation model used to validate tokens. Choose from the available moderation models found [here](https://docs.together.ai/docs/inference-models#moderation-models).<br/>
        /// Example: safety_model_name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_model")]
        public string? SafetyModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}