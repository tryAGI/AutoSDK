//HintName: G.Models.RealtimeTranscriptionSession.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Session description echoed by the server.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSession
    {
        /// <summary>
        /// Server-assigned session/request id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Realtime transcription model id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSession" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Server-assigned session/request id.
        /// </param>
        /// <param name="model">
        /// Realtime transcription model id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSession(
            string requestId,
            string model)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSession" /> class.
        /// </summary>
        public RealtimeTranscriptionSession()
        {
        }

    }
}