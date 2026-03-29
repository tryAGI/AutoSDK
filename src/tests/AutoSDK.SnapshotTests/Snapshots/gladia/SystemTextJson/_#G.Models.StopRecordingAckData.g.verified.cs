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
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RecordingDuration { get; set; }

        /// <summary>
        /// Audio duration left to process in seconds<br/>
        /// Example: 11.23F
        /// </summary>
        /// <example>11.23F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("recording_left_to_process")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RecordingLeftToProcess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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