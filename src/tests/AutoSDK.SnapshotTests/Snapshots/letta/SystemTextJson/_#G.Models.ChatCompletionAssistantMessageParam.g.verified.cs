//HintName: G.Models.ChatCompletionAssistantMessageParam.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Messages sent by the model in response to user messages.
    /// </summary>
    public sealed partial class ChatCompletionAssistantMessageParam
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"assistant"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "assistant";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::G.Audio? Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionContentPartTextParam, global::G.ChatCompletionContentPartRefusalParam>>, object>))]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionContentPartTextParam, global::G.ChatCompletionContentPartRefusalParam>>, object>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_call")]
        public global::G.FunctionCallInput? FunctionCall { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionMessageFunctionToolCallParam, global::G.ChatCompletionMessageCustomToolCallParam>>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAssistantMessageParam" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="content"></param>
        /// <param name="functionCall"></param>
        /// <param name="name"></param>
        /// <param name="refusal"></param>
        /// <param name="toolCalls"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionAssistantMessageParam(
            global::G.Audio? audio,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionContentPartTextParam, global::G.ChatCompletionContentPartRefusalParam>>, object>? content,
            global::G.FunctionCallInput? functionCall,
            string? name,
            string? refusal,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionMessageFunctionToolCallParam, global::G.ChatCompletionMessageCustomToolCallParam>>? toolCalls,
            string role = "assistant")
        {
            this.Role = role;
            this.Audio = audio;
            this.Content = content;
            this.FunctionCall = functionCall;
            this.Name = name;
            this.Refusal = refusal;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAssistantMessageParam" /> class.
        /// </summary>
        public ChatCompletionAssistantMessageParam()
        {
        }
    }
}