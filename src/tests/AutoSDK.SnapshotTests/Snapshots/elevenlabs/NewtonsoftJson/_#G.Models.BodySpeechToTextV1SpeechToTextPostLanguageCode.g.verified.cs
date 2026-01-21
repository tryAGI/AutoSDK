//HintName: G.Models.BodySpeechToTextV1SpeechToTextPostLanguageCode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An ISO-639-1 or ISO-639-3 language_code corresponding to the language of the audio file. Can sometimes improve transcription performance if known beforehand. Defaults to null, in this case the language is predicted automatically.
    /// </summary>
    public sealed partial class BodySpeechToTextV1SpeechToTextPostLanguageCode
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}