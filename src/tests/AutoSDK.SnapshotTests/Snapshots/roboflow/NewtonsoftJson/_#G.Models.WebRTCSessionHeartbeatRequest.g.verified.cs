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
        [global::Newtonsoft.Json.JsonProperty("session_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRTCSessionHeartbeatRequest" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="apiKey"></param>
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