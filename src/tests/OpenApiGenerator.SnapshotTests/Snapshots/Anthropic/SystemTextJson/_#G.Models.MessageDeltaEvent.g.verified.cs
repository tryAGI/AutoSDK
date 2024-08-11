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
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageDelta? Delta { get; set; }

        /// <summary>
        /// The type of a streaming event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.MessageStreamEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageStreamEventType? Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessageDeltaUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}