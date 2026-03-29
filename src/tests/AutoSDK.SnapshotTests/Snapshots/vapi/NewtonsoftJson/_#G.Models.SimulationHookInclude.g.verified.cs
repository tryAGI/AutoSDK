//HintName: G.Models.SimulationHookInclude.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationHookInclude
    {
        /// <summary>
        /// Include transcript in the hook payload<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript")]
        public bool? Transcript { get; set; }

        /// <summary>
        /// Include messages in the hook payload<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public bool? Messages { get; set; }

        /// <summary>
        /// Include recordingUrl in the hook payload<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recordingUrl")]
        public bool? RecordingUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationHookInclude" /> class.
        /// </summary>
        /// <param name="transcript">
        /// Include transcript in the hook payload<br/>
        /// Default Value: false
        /// </param>
        /// <param name="messages">
        /// Include messages in the hook payload<br/>
        /// Default Value: false
        /// </param>
        /// <param name="recordingUrl">
        /// Include recordingUrl in the hook payload<br/>
        /// Default Value: false
        /// </param>
        public SimulationHookInclude(
            bool? transcript,
            bool? messages,
            bool? recordingUrl)
        {
            this.Transcript = transcript;
            this.Messages = messages;
            this.RecordingUrl = recordingUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationHookInclude" /> class.
        /// </summary>
        public SimulationHookInclude()
        {
        }
    }
}