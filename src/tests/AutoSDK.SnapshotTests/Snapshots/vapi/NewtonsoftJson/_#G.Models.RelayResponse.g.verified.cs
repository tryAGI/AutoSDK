//HintName: G.Models.RelayResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RelayResponse
    {
        /// <summary>
        /// The status of the relay request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RelayResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the call, if delivered to a live call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callId")]
        public string? CallId { get; set; }

        /// <summary>
        /// The unique identifier of the session, if delivered to a headless session
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chatId")]
        public string? ChatId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the relay request
        /// </param>
        /// <param name="callId">
        /// The unique identifier of the call, if delivered to a live call
        /// </param>
        /// <param name="sessionId">
        /// The unique identifier of the session, if delivered to a headless session
        /// </param>
        /// <param name="chatId"></param>
        public RelayResponse(
            global::G.RelayResponseStatus status,
            string? callId,
            string? sessionId,
            string? chatId)
        {
            this.Status = status;
            this.CallId = callId;
            this.SessionId = sessionId;
            this.ChatId = chatId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayResponse" /> class.
        /// </summary>
        public RelayResponse()
        {
        }
    }
}