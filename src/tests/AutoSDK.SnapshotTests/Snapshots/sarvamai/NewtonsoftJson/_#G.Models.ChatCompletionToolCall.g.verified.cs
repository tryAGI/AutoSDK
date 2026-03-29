//HintName: G.Models.ChatCompletionToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionToolCall
    {
        /// <summary>
        /// Unique ID for this tool call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of tool call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatCompletionToolCallType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionToolCallFunction Function { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID for this tool call
        /// </param>
        /// <param name="function"></param>
        /// <param name="type">
        /// The type of tool call
        /// </param>
        public ChatCompletionToolCall(
            string id,
            global::G.ChatCompletionToolCallFunction function,
            global::G.ChatCompletionToolCallType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionToolCall" /> class.
        /// </summary>
        public ChatCompletionToolCall()
        {
        }
    }
}