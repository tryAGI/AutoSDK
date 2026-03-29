//HintName: G.Models.StreamingTranscriptionResultWithMessagesDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingTranscriptionResultWithMessagesDTO
    {
        /// <summary>
        /// Metadata for the given transcription &amp; audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TranscriptionMetadataDTO Metadata { get; set; } = default!;

        /// <summary>
        /// Transcription of the audio speech
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcription")]
        public global::G.TranscriptionDTO? Transcription { get; set; }

        /// <summary>
        /// If `translation` has been enabled, translation of the audio speech transcription
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translation")]
        public global::G.TranslationDTO? Translation { get; set; }

        /// <summary>
        /// If `summarization` has been enabled, summarization of the audio speech transcription
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summarization")]
        public global::G.SummarizationDTO? Summarization { get; set; }

        /// <summary>
        /// If `named_entity_recognition` has been enabled, the detected entities
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("named_entity_recognition")]
        public global::G.NamedEntityRecognitionDTO? NamedEntityRecognition { get; set; }

        /// <summary>
        /// If `sentiment_analysis` has been enabled, sentiment analysis of the audio speech transcription
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiment_analysis")]
        public global::G.SentimentAnalysisDTO? SentimentAnalysis { get; set; }

        /// <summary>
        /// If `chapterization` has been enabled, will generate chapters name for different parts of the given audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chapterization")]
        public global::G.ChapterizationDTO? Chapterization { get; set; }

        /// <summary>
        /// Real-Time messages sent by the server during the live transcription
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingTranscriptionResultWithMessagesDTO" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Metadata for the given transcription &amp; audio file
        /// </param>
        /// <param name="transcription">
        /// Transcription of the audio speech
        /// </param>
        /// <param name="translation">
        /// If `translation` has been enabled, translation of the audio speech transcription
        /// </param>
        /// <param name="summarization">
        /// If `summarization` has been enabled, summarization of the audio speech transcription
        /// </param>
        /// <param name="namedEntityRecognition">
        /// If `named_entity_recognition` has been enabled, the detected entities
        /// </param>
        /// <param name="sentimentAnalysis">
        /// If `sentiment_analysis` has been enabled, sentiment analysis of the audio speech transcription
        /// </param>
        /// <param name="chapterization">
        /// If `chapterization` has been enabled, will generate chapters name for different parts of the given audio.
        /// </param>
        /// <param name="messages">
        /// Real-Time messages sent by the server during the live transcription
        /// </param>
        public StreamingTranscriptionResultWithMessagesDTO(
            global::G.TranscriptionMetadataDTO metadata,
            global::G.TranscriptionDTO? transcription,
            global::G.TranslationDTO? translation,
            global::G.SummarizationDTO? summarization,
            global::G.NamedEntityRecognitionDTO? namedEntityRecognition,
            global::G.SentimentAnalysisDTO? sentimentAnalysis,
            global::G.ChapterizationDTO? chapterization,
            global::System.Collections.Generic.IList<string>? messages)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Transcription = transcription;
            this.Translation = translation;
            this.Summarization = summarization;
            this.NamedEntityRecognition = namedEntityRecognition;
            this.SentimentAnalysis = sentimentAnalysis;
            this.Chapterization = chapterization;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingTranscriptionResultWithMessagesDTO" /> class.
        /// </summary>
        public StreamingTranscriptionResultWithMessagesDTO()
        {
        }
    }
}