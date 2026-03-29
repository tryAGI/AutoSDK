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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RelayResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RelayResponseStatus Status { get; set; }

        /// <summary>
        /// The unique identifier of the call, if delivered to a live call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        public string? CallId { get; set; }

        /// <summary>
        /// The unique identifier of the session, if delivered to a headless session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatId")]
        public string? ChatId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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