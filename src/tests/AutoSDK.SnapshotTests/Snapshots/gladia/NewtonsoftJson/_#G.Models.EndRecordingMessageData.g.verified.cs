//HintName: G.Models.EndRecordingMessageData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndRecordingMessageData
    {
        /// <summary>
        /// Total audio duration in seconds<br/>
        /// Example: 344.45F
        /// </summary>
        /// <example>344.45F</example>
        [global::Newtonsoft.Json.JsonProperty("recording_duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double RecordingDuration { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndRecordingMessageData" /> class.
        /// </summary>
        /// <param name="recordingDuration">
        /// Total audio duration in seconds<br/>
        /// Example: 344.45F
        /// </param>
        public EndRecordingMessageData(
            double recordingDuration)
        {
            this.RecordingDuration = recordingDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndRecordingMessageData" /> class.
        /// </summary>
        public EndRecordingMessageData()
        {
        }
    }
}