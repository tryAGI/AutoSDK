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
        [global::Newtonsoft.Json.JsonProperty("headers", Required = global::Newtonsoft.Json.Required.Always)]
        public object? Headers { get; set; } = default!;

        /// <summary>
        /// The webhook payload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload", Required = global::Newtonsoft.Json.Required.Always)]
        public object? Payload { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}