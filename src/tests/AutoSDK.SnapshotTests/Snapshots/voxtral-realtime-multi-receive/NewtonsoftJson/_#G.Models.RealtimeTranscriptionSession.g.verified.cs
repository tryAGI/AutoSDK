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
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// Realtime transcription model id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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