//HintName: G.Models.WebRTCSessionHeartbeatRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for WebRTC session heartbeat and end endpoints.
    /// </summary>
    public sealed partial class WebRTCSessionHeartbeatRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRTCSessionHeartbeatRequest" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="apiKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebRTCSessionHeartbeatRequest(
            string sessionId,
            string apiKey)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRTCSessionHeartbeatRequest" /> class.
        /// </summary>
        public WebRTCSessionHeartbeatRequest()
        {
        }
    }
}