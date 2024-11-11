//HintName: G.Models.TranscriptOptionalParamsSpeakersExpected.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Tells the speaker label model how many speakers it should attempt to identify, up to 10. See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more details.
    /// </summary>
    public sealed partial class TranscriptOptionalParamsSpeakersExpected
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOptionalParamsSpeakersExpected" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TranscriptOptionalParamsSpeakersExpected(
 )
        {
        }
    }
}