//HintName: G.Models.ChatToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tool call made by the assistant
    /// </summary>
    public sealed partial class ChatToolCall
    {
        /// <summary>
        /// Tool call identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatToolCallTypeJsonConverter))]
        public global::G.ChatToolCallType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatToolCallFunction Function { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// Tool call identifier
        /// </param>
        /// <param name="function"></param>
        /// <param name="type"></param>
        public ChatToolCall(
            string id,
            global::G.ChatToolCallFunction function,
            global::G.ChatToolCallType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCall" /> class.
        /// </summary>
        public ChatToolCall()
        {
        }
    }
}