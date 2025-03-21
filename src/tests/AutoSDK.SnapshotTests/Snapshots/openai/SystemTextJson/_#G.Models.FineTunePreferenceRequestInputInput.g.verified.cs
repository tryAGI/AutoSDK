//HintName: G.Models.FineTunePreferenceRequestInputInput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FineTunePreferenceRequestInputInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ChatCompletionRequestSystemMessage, global::G.ChatCompletionRequestUserMessage, global::G.FineTuneChatCompletionRequestAssistantMessage?, global::G.ChatCompletionRequestToolMessage, global::G.ChatCompletionRequestFunctionMessage>>? Messages { get; set; }

        /// <summary>
        /// Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// A list of tools the model may generate JSON inputs for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreferenceRequestInputInput" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="parallelToolCalls">
        /// Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may generate JSON inputs for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTunePreferenceRequestInputInput(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ChatCompletionRequestSystemMessage, global::G.ChatCompletionRequestUserMessage, global::G.FineTuneChatCompletionRequestAssistantMessage?, global::G.ChatCompletionRequestToolMessage, global::G.ChatCompletionRequestFunctionMessage>>? messages,
            bool? parallelToolCalls,
            global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? tools)
        {
            this.Messages = messages;
            this.ParallelToolCalls = parallelToolCalls;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTunePreferenceRequestInputInput" /> class.
        /// </summary>
        public FineTunePreferenceRequestInputInput()
        {
        }
    }
}