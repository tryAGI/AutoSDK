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
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ChatCompletionRequestSystemMessage, global::G.ChatCompletionRequestUserMessage, global::G.FineTuneChatCompletionRequestAssistantMessage, global::G.FineTuneChatCompletionRequestFunctionMessage?>>? Messages { get; set; }

        /// <summary>
        /// A list of functions the model may generate JSON inputs for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("functions")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionFunctions>? Functions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneChatRequestInput" /> class.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="functions">
        /// A list of functions the model may generate JSON inputs for.
        /// </param>
        public FinetuneChatRequestInput(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ChatCompletionRequestSystemMessage, global::G.ChatCompletionRequestUserMessage, global::G.FineTuneChatCompletionRequestAssistantMessage, global::G.FineTuneChatCompletionRequestFunctionMessage?>>? messages,
            global::System.Collections.Generic.IList<global::G.ChatCompletionFunctions>? functions)
        {
            this.Messages = messages;
            this.Functions = functions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneChatRequestInput" /> class.
        /// </summary>
        public FinetuneChatRequestInput()
        {
        }
    }
}