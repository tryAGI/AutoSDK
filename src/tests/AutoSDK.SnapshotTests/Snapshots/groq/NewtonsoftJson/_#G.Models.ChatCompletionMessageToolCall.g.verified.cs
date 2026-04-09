//HintName: G.Models.ChatCompletionMessageToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionMessageToolCall
    {
        /// <summary>
        /// The ID of the tool call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The type of the tool. Currently, only `function` is supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter))]
        public global::G.ChatCompletionMessageToolCallType Type { get; set; }

        /// <summary>
        /// The function that the model called.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatCompletionMessageToolCallFunction Function { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the tool call.
        /// </param>
        /// <param name="function">
        /// The function that the model called.
        /// </param>
        /// <param name="type">
        /// The type of the tool. Currently, only `function` is supported.
        /// </param>
        public ChatCompletionMessageToolCall(
            string id,
            global::G.ChatCompletionMessageToolCallFunction function,
            global::G.ChatCompletionMessageToolCallType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageToolCall" /> class.
        /// </summary>
        public ChatCompletionMessageToolCall()
        {
        }
    }
}