//HintName: G.Models.StopRecordingAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StopRecordingAction
    {
        /// <summary>
        /// Default Value: stop_recording<br/>
        /// Example: stop_recording
        /// </summary>
        /// <default>global::G.StopRecordingActionType.StopRecording</default>
        /// <example>stop_recording</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StopRecordingActionTypeJsonConverter))]
        public global::G.StopRecordingActionType Type { get; set; } = global::G.StopRecordingActionType.StopRecording;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopRecordingAction" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: stop_recording<br/>
        /// Example: stop_recording
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopRecordingAction(
            global::G.StopRecordingActionType type = global::G.StopRecordingActionType.StopRecording)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopRecordingAction" /> class.
        /// </summary>
        public StopRecordingAction()
        {
        }
    }
}