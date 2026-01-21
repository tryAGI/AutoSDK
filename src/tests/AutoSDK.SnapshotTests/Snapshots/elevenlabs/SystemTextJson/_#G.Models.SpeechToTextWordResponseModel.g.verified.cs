//HintName: G.Models.SpeechToTextWordResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Word-level detail of the transcription with timing information.<br/>
    /// Example: {"characters":[{"char":"H","end":0.1,"start":0},{"char":"e","end":0.2,"start":0.1},{"char":"l","end":0.3,"start":0.2},{"char":"l","end":0.4,"start":0.3},{"char":"o","end":0.5,"start":0.4}],"end":0.5,"logprob":-0.124,"speaker_id":"speaker_1","start":0,"text":"Hello","type":"word"}
    /// </summary>
    public sealed partial class SpeechToTextWordResponseModel
    {
        /// <summary>
        /// The word or sound that was transcribed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The start time of the word or sound in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// The end time of the word or sound in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// The type of the word or sound. 'audio_event' is used for non-word sounds like laughter or footsteps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeechToTextWordResponseModelTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpeechToTextWordResponseModelType Type { get; set; }

        /// <summary>
        /// Unique identifier for the speaker of this word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_id")]
        public string? SpeakerId { get; set; }

        /// <summary>
        /// The log of the probability with which this word was predicted. Logprobs are in range [-infinity, 0], higher logprobs indicate a higher confidence the model has in its predictions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Logprob { get; set; }

        /// <summary>
        /// The characters that make up the word and their timing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        public global::System.Collections.Generic.IList<global::G.SpeechToTextCharacterResponseModel>? Characters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextWordResponseModel" /> class.
        /// </summary>
        /// <param name="text">
        /// The word or sound that was transcribed.
        /// </param>
        /// <param name="start">
        /// The start time of the word or sound in seconds.
        /// </param>
        /// <param name="end">
        /// The end time of the word or sound in seconds.
        /// </param>
        /// <param name="type">
        /// The type of the word or sound. 'audio_event' is used for non-word sounds like laughter or footsteps.
        /// </param>
        /// <param name="speakerId">
        /// Unique identifier for the speaker of this word.
        /// </param>
        /// <param name="logprob">
        /// The log of the probability with which this word was predicted. Logprobs are in range [-infinity, 0], higher logprobs indicate a higher confidence the model has in its predictions.
        /// </param>
        /// <param name="characters">
        /// The characters that make up the word and their timing information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToTextWordResponseModel(
            string text,
            global::G.SpeechToTextWordResponseModelType type,
            double logprob,
            double? start,
            double? end,
            string? speakerId,
            global::System.Collections.Generic.IList<global::G.SpeechToTextCharacterResponseModel>? characters)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
            this.Logprob = logprob;
            this.Start = start;
            this.End = end;
            this.SpeakerId = speakerId;
            this.Characters = characters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextWordResponseModel" /> class.
        /// </summary>
        public SpeechToTextWordResponseModel()
        {
        }
    }
}