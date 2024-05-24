//HintName: G.Models.WebhookCheckRunRequestedActionFormEncoded.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The check_run.requested_action webhook encoded with URL encoding
    /// </summary>
    public sealed partial class WebhookCheckRunRequestedActionFormEncoded
    {
        /// <summary>
        /// A URL-encoded string of the check_run.requested_action JSON payload. The decoded payload is a JSON object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}