//HintName: G.Models.MessageDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageDeltaEvent
    {
        /// <summary>
        /// Default Value: message_delta
        /// </summary>
        /// <default>global::G.MessageDeltaEventType.MessageDelta</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessageDeltaEventType Type { get; set; } = global::G.MessageDeltaEventType.MessageDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageDelta Delta { get; set; } = default!;

        /// <summary>
        /// Billing and rate-limit usage.<br/>
        /// Anthropic's API bills and rate-limits by token counts, as tokens represent the underlying cost to our systems.<br/>
        /// Under the hood, the API transforms requests into a format suitable for the model. The model's output then goes through a parsing stage before becoming an API response. As a result, the token counts in `usage` will not match one-to-one with the exact visible content of an API request or response.<br/>
        /// For example, `output_tokens` will be non-zero, even for an empty string response from Claude.
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
        /// <param name="type">
        /// Default Value: message_delta
        /// </param>
        /// <param name="delta"></param>
        /// <param name="usage">
        /// Billing and rate-limit usage.<br/>
        /// Anthropic's API bills and rate-limits by token counts, as tokens represent the underlying cost to our systems.<br/>
        /// Under the hood, the API transforms requests into a format suitable for the model. The model's output then goes through a parsing stage before becoming an API response. As a result, the token counts in `usage` will not match one-to-one with the exact visible content of an API request or response.<br/>
        /// For example, `output_tokens` will be non-zero, even for an empty string response from Claude.
        /// </param>
        public MessageDeltaEvent(
            global::G.MessageDelta delta,
            global::G.MessageDeltaUsage usage,
            global::G.MessageDeltaEventType type = global::G.MessageDeltaEventType.MessageDelta)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaEvent" /> class.
        /// </summary>
        public MessageDeltaEvent()
        {
        }
    }
}