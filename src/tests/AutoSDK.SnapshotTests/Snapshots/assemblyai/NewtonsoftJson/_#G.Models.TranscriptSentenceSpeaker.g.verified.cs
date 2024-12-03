//HintName: G.Models.TranscriptSentenceSpeaker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The speaker of the sentence if [Speaker Diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, else null
    /// </summary>
    public sealed partial class TranscriptSentenceSpeaker
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptSentenceSpeaker" /> class.
        /// </summary>
        public TranscriptSentenceSpeaker(
 )
        {
        }
    }
}