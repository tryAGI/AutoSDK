//HintName: G.Models.UtteranceDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UtteranceDTO
    {
        /// <summary>
        /// Start timestamp in seconds of this utterance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public double Start { get; set; } = default!;

        /// <summary>
        /// End timestamp in seconds of this utterance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public double End { get; set; } = default!;

        /// <summary>
        /// Confidence on the transcribed utterance (1 = 100% confident)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// Audio channel of where this utterance has been transcribed from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel", Required = global::Newtonsoft.Json.Required.Always)]
        public int Channel { get; set; } = default!;

        /// <summary>
        /// If `diarization` enabled, speaker identification number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        /// List of words of the utterance, split by timestamp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("words", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.WordDTO> Words { get; set; } = default!;

        /// <summary>
        /// Transcription for this utterance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Spoken language in this utterance<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TranscriptionLanguageCodeEnum Language { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceDTO" /> class.
        /// </summary>
        /// <param name="start">
        /// Start timestamp in seconds of this utterance
        /// </param>
        /// <param name="end">
        /// End timestamp in seconds of this utterance
        /// </param>
        /// <param name="confidence">
        /// Confidence on the transcribed utterance (1 = 100% confident)
        /// </param>
        /// <param name="channel">
        /// Audio channel of where this utterance has been transcribed from
        /// </param>
        /// <param name="words">
        /// List of words of the utterance, split by timestamp
        /// </param>
        /// <param name="text">
        /// Transcription for this utterance
        /// </param>
        /// <param name="language">
        /// Spoken language in this utterance<br/>
        /// Example: en
        /// </param>
        /// <param name="speaker">
        /// If `diarization` enabled, speaker identification number
        /// </param>
        public UtteranceDTO(
            double start,
            double end,
            double confidence,
            int channel,
            global::System.Collections.Generic.IList<global::G.WordDTO> words,
            string text,
            global::G.TranscriptionLanguageCodeEnum language,
            int? speaker)
        {
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
            this.Channel = channel;
            this.Speaker = speaker;
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtteranceDTO" /> class.
        /// </summary>
        public UtteranceDTO()
        {
        }
    }
}