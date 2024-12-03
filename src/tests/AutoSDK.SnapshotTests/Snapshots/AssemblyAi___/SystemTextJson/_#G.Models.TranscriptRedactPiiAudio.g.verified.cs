//HintName: G.Models.TranscriptRedactPiiAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether a redacted version of the audio file was generated,<br/>
    /// either true or false. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more information.
    /// </summary>
    public sealed partial class TranscriptRedactPiiAudio
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptRedactPiiAudio" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TranscriptRedactPiiAudio(
 )
        {
        }
    }
}