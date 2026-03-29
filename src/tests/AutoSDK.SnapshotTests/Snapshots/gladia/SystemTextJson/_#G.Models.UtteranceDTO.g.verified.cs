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
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// End timestamp in seconds of this utterance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// Confidence on the transcribed utterance (1 = 100% confident)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Audio channel of where this utterance has been transcribed from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Channel { get; set; }

        /// <summary>
        /// If `diarization` enabled, speaker identification number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        /// List of words of the utterance, split by timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.WordDTO> Words { get; set; }

        /// <summary>
        /// Transcription for this utterance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Spoken language in this utterance<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscriptionLanguageCodeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TranscriptionLanguageCodeEnum Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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