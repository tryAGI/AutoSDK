//HintName: G.Models.TranscriptWords.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An array of temporally-sequential word objects, one for each word in the transcript.<br/>
    /// See [Speech recognition](https://www.assemblyai.com/docs/models/speech-recognition) for more information.
    /// </summary>
    public sealed partial class TranscriptWords
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}