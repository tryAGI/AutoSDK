//HintName: G.Models.TranscriptSpeechThreshold.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defaults to null. Reject audio files that contain less than this fraction of speech.<br/>
    /// Valid values are in the range [0, 1] inclusive.
    /// </summary>
    public sealed partial class TranscriptSpeechThreshold
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptSpeechThreshold" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TranscriptSpeechThreshold(
 )
        {
        }
    }
}