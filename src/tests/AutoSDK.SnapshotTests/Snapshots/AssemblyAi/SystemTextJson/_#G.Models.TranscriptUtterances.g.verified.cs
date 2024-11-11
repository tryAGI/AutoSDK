//HintName: G.Models.TranscriptUtterances.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// When dual_channel or speaker_labels is enabled, a list of turn-by-turn utterance objects.<br/>
    /// See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more information.
    /// </summary>
    public sealed partial class TranscriptUtterances
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptUtterances" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TranscriptUtterances(
 )
        {
        }
    }
}