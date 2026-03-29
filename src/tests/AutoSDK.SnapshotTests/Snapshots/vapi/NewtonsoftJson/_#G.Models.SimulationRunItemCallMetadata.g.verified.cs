//HintName: G.Models.SimulationRunItemCallMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunItemCallMetadata
    {
        /// <summary>
        /// This is the transcript of the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// This is the list of conversation messages in OpenAI format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<object>? Messages { get; set; }

        /// <summary>
        /// This is the URL to the call recording.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recordingUrl")]
        public string? RecordingUrl { get; set; }

        /// <summary>
        /// This is the call monitoring data (live listen URL).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("monitor")]
        public global::G.SimulationRunItemCallMonitor? Monitor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemCallMetadata" /> class.
        /// </summary>
        /// <param name="transcript">
        /// This is the transcript of the conversation.
        /// </param>
        /// <param name="messages">
        /// This is the list of conversation messages in OpenAI format.
        /// </param>
        /// <param name="recordingUrl">
        /// This is the URL to the call recording.
        /// </param>
        /// <param name="monitor">
        /// This is the call monitoring data (live listen URL).
        /// </param>
        public SimulationRunItemCallMetadata(
            string? transcript,
            global::System.Collections.Generic.IList<object>? messages,
            string? recordingUrl,
            global::G.SimulationRunItemCallMonitor? monitor)
        {
            this.Transcript = transcript;
            this.Messages = messages;
            this.RecordingUrl = recordingUrl;
            this.Monitor = monitor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemCallMetadata" /> class.
        /// </summary>
        public SimulationRunItemCallMetadata()
        {
        }
    }
}