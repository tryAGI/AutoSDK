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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The error that occurred while updating the shard. Possible errors:  <br/>
        ///   <br/>
        /// * The length of the string in the secret field is not valid.<br/>
        /// * The URL in the transport's callback field is not valid. The URL must use the HTTPS protocol and the 443 port number.<br/>
        /// * The value specified in the method field is not valid.<br/>
        /// * The callback field is required if you specify the webhook transport method.<br/>
        /// * The session\_id field is required if you specify the WebSocket transport method.<br/>
        /// * The websocket session is not connected.<br/>
        /// * The shard id is outside of the conduit’s range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Error codes used to represent a specific error condition while attempting to update shards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}