//HintName: G.Models.StopRecordingAckData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StopRecordingAckData
    {
        /// <summary>
        /// Total audio duration in seconds<br/>
        /// Example: 344.45F
        /// </summary>
        /// <example>344.45F</example>
        [global::Newtonsoft.Json.JsonProperty("recording_duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double RecordingDuration { get; set; } = default!;

        /// <summary>
        /// Audio duration left to process in seconds<br/>
        /// Example: 11.23F
        /// </summary>
        /// <example>11.23F</example>
        [global::Newtonsoft.Json.JsonProperty("recording_left_to_process", Required = global::Newtonsoft.Json.Required.Always)]
        public double RecordingLeftToProcess { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopRecordingAckData" /> class.
        /// </summary>
        /// <param name="recordingDuration">
        /// Total audio duration in seconds<br/>
        /// Example: 344.45F
        /// </param>
        /// <param name="recordingLeftToProcess">
        /// Audio duration left to process in seconds<br/>
        /// Example: 11.23F
        /// </param>
        public StopRecordingAckData(
            double recordingDuration,
            double recordingLeftToProcess)
        {
            this.RecordingDuration = recordingDuration;
            this.RecordingLeftToProcess = recordingLeftToProcess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopRecordingAckData" /> class.
        /// </summary>
        public StopRecordingAckData()
        {
        }
    }
}