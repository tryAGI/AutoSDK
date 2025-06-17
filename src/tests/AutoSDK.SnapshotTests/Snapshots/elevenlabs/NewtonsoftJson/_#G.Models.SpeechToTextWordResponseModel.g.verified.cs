//HintName: G.Models.SpeechToTextWordResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Word-level detail of the transcription with timing information.
    /// </summary>
    public sealed partial class SpeechToTextWordResponseModel
    {
        /// <summary>
        /// The word or sound that was transcribed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The start time of the word or sound in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start")]
        public double? Start { get; set; }

        /// <summary>
        /// The end time of the word or sound in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end")]
        public double? End { get; set; }

        /// <summary>
        /// The type of the word or sound. 'audio_event' is used for non-word sounds like laughter or footsteps.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SpeechToTextWordResponseModelType Type { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the speaker of this word.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_id")]
        public string? SpeakerId { get; set; }

        /// <summary>
        /// The log of the probability with which this word was predicted. Logprobs are in range [-infinity, 0], higher logprobs indicate a higher confidence the model has in its predictions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprob", Required = global::Newtonsoft.Json.Required.Always)]
        public double Logprob { get; set; } = default!;

        /// <summary>
        /// The characters that make up the word and their timing information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("characters")]
        public global::System.Collections.Generic.IList<global::G.SpeechToTextCharacterResponseModel>? Characters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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