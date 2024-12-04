//HintName: G.Models.RealtimeServerEventConversationItemInputAudioTranscriptionFailedError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of the transcription error.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationItemInputAudioTranscriptionFailedError
    {
        /// <summary>
        /// The type of error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Error code, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A human-readable error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Parameter related to the error, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param")]
        public string? Param { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionFailedError" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of error.
        /// </param>
        /// <param name="code">
        /// Error code, if any.
        /// </param>
        /// <param name="message">
        /// A human-readable error message.
        /// </param>
        /// <param name="param">
        /// Parameter related to the error, if any.
        /// </param>
        public RealtimeServerEventConversationItemInputAudioTranscriptionFailedError(
            string? type,
            string? code,
            string? message,
            string? param)
        {
            this.Type = type;
            this.Code = code;
            this.Message = message;
            this.Param = param;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemInputAudioTranscriptionFailedError" /> class.
        /// </summary>
        public RealtimeServerEventConversationItemInputAudioTranscriptionFailedError()
        {
        }
    }
}