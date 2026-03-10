//HintName: G.Models.MultichannelSpeechToTextResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for multichannel speech-to-text transcription.<br/>
    /// Example: {"transcripts":[{"language_code":"en","language_probability":0.98,"text":"Hello from channel one.","words":[{"end":0.5,"logprob":-0.124,"speaker_id":"speaker_0","start":0.0,"text":"Hello","type":"word"},{"end":0.5,"logprob":0.0,"speaker_id":"speaker_0","start":0.5,"text":" ","type":"spacing"},{"end":0.8,"logprob":-0.089,"speaker_id":"speaker_0","start":0.5,"text":"from","type":"word"}]},{"language_code":"en","language_probability":0.97,"text":"Greetings from channel two.","words":[{"end":0.7,"logprob":-0.156,"speaker_id":"speaker_1","start":0.1,"text":"Greetings","type":"word"},{"end":0.7,"logprob":0.0,"speaker_id":"speaker_1","start":0.7,"text":" ","type":"spacing"},{"end":1.0,"logprob":-0.078,"speaker_id":"speaker_1","start":0.7,"text":"from","type":"word"}]}]}
    /// </summary>
    public sealed partial class MultichannelSpeechToTextResponseModel
    {
        /// <summary>
        /// List of transcripts, one for each audio channel. Each transcript contains the text and word-level details for its respective channel.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcripts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SpeechToTextChunkResponseModel> Transcripts { get; set; } = default!;

        /// <summary>
        /// The transcription ID of the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcription_id")]
        public string? TranscriptionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultichannelSpeechToTextResponseModel" /> class.
        /// </summary>
        /// <param name="transcripts">
        /// List of transcripts, one for each audio channel. Each transcript contains the text and word-level details for its respective channel.
        /// </param>
        /// <param name="transcriptionId">
        /// The transcription ID of the response.
        /// </param>
        public MultichannelSpeechToTextResponseModel(
            global::System.Collections.Generic.IList<global::G.SpeechToTextChunkResponseModel> transcripts,
            string? transcriptionId)
        {
            this.Transcripts = transcripts ?? throw new global::System.ArgumentNullException(nameof(transcripts));
            this.TranscriptionId = transcriptionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultichannelSpeechToTextResponseModel" /> class.
        /// </summary>
        public MultichannelSpeechToTextResponseModel()
        {
        }
    }
}