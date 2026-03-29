//HintName: G.Models.MessagesResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Non-streaming response from the Anthropic Messages API with OpenRouter extensions
    /// </summary>
    public sealed partial class MessagesResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BaseMessagesResultType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.BaseMessagesResultRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.BaseMessagesResultContainer, object> Container { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItems> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.BaseMessagesResultStopReason?, object> StopReason { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop_sequence")]
        public string? StopSequence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessagesResultUsage Usage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.MessagesResultProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResult" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="container"></param>
        /// <param name="content"></param>
        /// <param name="model"></param>
        /// <param name="stopReason"></param>
        /// <param name="usage"></param>
        /// <param name="type"></param>
        /// <param name="role"></param>
        /// <param name="stopSequence"></param>
        /// <param name="provider"></param>
        public MessagesResult(
            string id,
            global::G.OneOf<global::G.BaseMessagesResultContainer, object> container,
            global::System.Collections.Generic.IList<global::G.BaseMessagesResultContentItems> content,
            string model,
            global::G.OneOf<global::G.BaseMessagesResultStopReason?, object> stopReason,
            global::G.MessagesResultUsage usage,
            global::G.BaseMessagesResultType type,
            global::G.BaseMessagesResultRole role,
            string? stopSequence,
            global::G.MessagesResultProvider? provider)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Role = role;
            this.Container = container;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.StopReason = stopReason;
            this.StopSequence = stopSequence;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResult" /> class.
        /// </summary>
        public MessagesResult()
        {
        }
    }
}