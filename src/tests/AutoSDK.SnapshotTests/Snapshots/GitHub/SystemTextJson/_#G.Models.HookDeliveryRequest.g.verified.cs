//HintName: G.Models.HookDeliveryRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HookDeliveryRequest
    {
        /// <summary>
        /// The request headers sent with the webhook delivery.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? Headers { get; set; }

        /// <summary>
        /// The webhook payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HookDeliveryRequest" /> class.
        /// </summary>
        /// <param name="headers">
        /// The request headers sent with the webhook delivery.
        /// </param>
        /// <param name="payload">
        /// The webhook payload.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public HookDeliveryRequest(
            object? headers,
            object? payload)
        {
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HookDeliveryRequest" /> class.
        /// </summary>
        public HookDeliveryRequest()
        {
        }
    }
}