//HintName: G.Models.MessageDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A delta event in a streaming conversation.
    /// </summary>
    public sealed partial class MessageDeltaEvent
    {
        /// <summary>
        /// A delta in a streaming message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageDelta Delta { get; set; } = default!;

        /// <summary>
        /// The type of a streaming event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageStreamEventType Type { get; set; } = default!;

        /// <summary>
        /// Billing and rate-limit usage.<br/>
        /// Anthropic's API bills and rate-limits by token counts, as tokens represent the<br/>
        /// underlying cost to our systems.<br/>
        /// Under the hood, the API transforms requests into a format suitable for the<br/>
        /// model. The model's output then goes through a parsing stage before becoming an<br/>
        /// API response. As a result, the token counts in `usage` will not match one-to-one<br/>
        /// with the exact visible content of an API request or response.<br/>
        /// For example, `output_tokens` will be non-zero, even for an empty string response<br/>
        /// from Claude.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageDeltaUsage Usage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta">
        /// A delta in a streaming message.
        /// </param>
        /// <param name="type">
        /// The type of a streaming event.
        /// </param>
        /// <param name="usage">
        /// Billing and rate-limit usage.<br/>
        /// Anthropic's API bills and rate-limits by token counts, as tokens represent the<br/>
        /// underlying cost to our systems.<br/>
        /// Under the hood, the API transforms requests into a format suitable for the<br/>
        /// model. The model's output then goes through a parsing stage before becoming an<br/>
        /// API response. As a result, the token counts in `usage` will not match one-to-one<br/>
        /// with the exact visible content of an API request or response.<br/>
        /// For example, `output_tokens` will be non-zero, even for an empty string response<br/>
        /// from Claude.
        /// </param>
        public MessageDeltaEvent(
            global::G.MessageDelta delta,
            global::G.MessageStreamEventType type,
            global::G.MessageDeltaUsage usage)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Type = type;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaEvent" /> class.
        /// </summary>
        public MessageDeltaEvent()
        {
        }
    }
}