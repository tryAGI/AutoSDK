//HintName: G.Models.FinetuneChatRequestInput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The per-line training example of a fine-tuning input file for chat models
    /// </summary>
    public sealed partial class FinetuneChatRequestInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<global::System.OneOf<global::G.ChatCompletionRequestSystemMessage?, global::G.ChatCompletionRequestUserMessage?, global::G.FineTuneChatCompletionRequestAssistantMessage?, global::G.ChatCompletionRequestToolMessage?, global::G.ChatCompletionRequestFunctionMessage?>>? Messages { get; set; }

        /// <summary>
        /// A list of tools the model may generate JSON inputs for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionTool>? Tools { get; set; }

        /// <summary>
        /// Whether to enable [parallel function calling](/docs/guides/function-calling/parallel-function-calling) during tool use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// A list of functions the model may generate JSON inputs for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("functions")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionFunctions>? Functions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}