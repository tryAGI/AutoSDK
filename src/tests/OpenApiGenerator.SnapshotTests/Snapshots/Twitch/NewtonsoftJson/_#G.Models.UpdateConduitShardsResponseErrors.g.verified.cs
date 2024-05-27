//HintName: G.Models.UpdateConduitShardsResponseErrors.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConduitShardsResponseErrors
    {
        /// <summary>
        /// Shard ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The error that occurred while updating the shard. Possible errors:  
        ///   
        /// * The length of the string in the secret field is not valid.
        /// * The URL in the transport's callback field is not valid. The URL must use the HTTPS protocol and the 443 port number.
        /// * The value specified in the method field is not valid.
        /// * The callback field is required if you specify the webhook transport method.
        /// * The session\_id field is required if you specify the WebSocket transport method.
        /// * The websocket session is not connected.
        /// * The shard id is outside of the conduit’s range.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Error codes used to represent a specific error condition while attempting to update shards.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}