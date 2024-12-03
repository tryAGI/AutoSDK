//HintName: G.Models.HookDeliveryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HookDeliveryResponse
    {
        /// <summary>
        /// The response headers received when the delivery was made.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? Headers { get; set; }

        /// <summary>
        /// The response payload received.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HookDeliveryResponse" /> class.
        /// </summary>
        /// <param name="headers">
        /// The response headers received when the delivery was made.
        /// </param>
        /// <param name="payload">
        /// The response payload received.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public HookDeliveryResponse(
            object? headers,
            string? payload)
        {
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HookDeliveryResponse" /> class.
        /// </summary>
        public HookDeliveryResponse()
        {
        }
    }
}