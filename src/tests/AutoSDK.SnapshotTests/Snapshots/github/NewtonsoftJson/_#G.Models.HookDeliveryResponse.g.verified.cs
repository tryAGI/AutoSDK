﻿//HintName: G.Models.HookDeliveryResponse.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("headers", Required = global::Newtonsoft.Json.Required.Always)]
        public object? Headers { get; set; } = default!;

        /// <summary>
        /// The response payload received.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Payload { get; set; } = default!;

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