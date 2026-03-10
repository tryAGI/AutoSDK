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
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// The response payload received.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload")]
        public string? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public HookDeliveryResponse(
            object? headers,
            string? payload)
        {
            this.Headers = headers;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HookDeliveryResponse" /> class.
        /// </summary>
        public HookDeliveryResponse()
        {
        }
    }
}