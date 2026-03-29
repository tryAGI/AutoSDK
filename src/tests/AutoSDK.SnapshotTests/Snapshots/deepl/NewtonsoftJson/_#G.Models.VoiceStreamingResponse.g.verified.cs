//HintName: G.Models.VoiceStreamingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceStreamingResponse
    {
        /// <summary>
        /// The WebSocket URL to use for establishing the streaming connection. This URL is ephemeral and valid for one-time use only.<br/>
        /// Example: wss://api.deepl.com/v3/voice/realtime/connect
        /// </summary>
        /// <example>wss://api.deepl.com/v3/voice/realtime/connect</example>
        [global::Newtonsoft.Json.JsonProperty("streaming_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StreamingUrl { get; set; } = default!;

        /// <summary>
        /// A unique ephemeral token for authentication with the streaming endpoint. Pass this as a query parameter when connecting to the WebSocket URL.<br/>
        /// Example: VGhpcyBpcyBhIGZha2UgdG9rZW4K
        /// </summary>
        /// <example>VGhpcyBpcyBhIGZha2UgdG9rZW4K</example>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// Internal use only. A unique identifier for the requested stream.<br/>
        /// Example: 4f911080-cfe2-41d4-8269-0e6ec15a0354
        /// </summary>
        /// <example>4f911080-cfe2-41d4-8269-0e6ec15a0354</example>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceStreamingResponse" /> class.
        /// </summary>
        /// <param name="streamingUrl">
        /// The WebSocket URL to use for establishing the streaming connection. This URL is ephemeral and valid for one-time use only.<br/>
        /// Example: wss://api.deepl.com/v3/voice/realtime/connect
        /// </param>
        /// <param name="token">
        /// A unique ephemeral token for authentication with the streaming endpoint. Pass this as a query parameter when connecting to the WebSocket URL.<br/>
        /// Example: VGhpcyBpcyBhIGZha2UgdG9rZW4K
        /// </param>
        /// <param name="sessionId">
        /// Internal use only. A unique identifier for the requested stream.<br/>
        /// Example: 4f911080-cfe2-41d4-8269-0e6ec15a0354
        /// </param>
        public VoiceStreamingResponse(
            string streamingUrl,
            string token,
            string? sessionId)
        {
            this.StreamingUrl = streamingUrl ?? throw new global::System.ArgumentNullException(nameof(streamingUrl));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceStreamingResponse" /> class.
        /// </summary>
        public VoiceStreamingResponse()
        {
        }
    }
}