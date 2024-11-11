//HintName: G.Models.Transcript.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A transcript object
    /// </summary>
    public sealed partial class Transcript
    {
        /// <summary>
        /// The unique identifier of your transcript
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The URL of the media that was transcribed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AudioUrl { get; set; } = default!;

        /// <summary>
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TranscriptStatus Status { get; set; } = default!;

        /// <summary>
        /// The language of your audio file.<br/>
        /// Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/concepts/supported-languages).<br/>
        /// The default value is 'en_us'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_code")]
        public global::G.AnyOf<global::G.TranscriptLanguageCode?, string>? LanguageCode { get; set; }

        /// <summary>
        /// Whether [Automatic language detection](https://www.assemblyai.com/docs/models/speech-recognition#automatic-language-detection) is enabled, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_detection")]
        public object? LanguageDetection { get; set; }

        /// <summary>
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_confidence_threshold", Required = global::Newtonsoft.Json.Required.Always)]
        public float LanguageConfidenceThreshold { get; set; } = default!;

        /// <summary>
        /// The confidence score for the detected language, between 0.0 (low confidence) and 1.0 (high confidence)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double LanguageConfidence { get; set; } = default!;

        /// <summary>
        /// The speech model used for the transcription. When `null`, the default model is used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speech_model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.SpeechModel2?, object> SpeechModel { get; set; } = default!;

        /// <summary>
        /// The textual transcript of your media file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public object? Text { get; set; }

        /// <summary>
        /// An array of temporally-sequential word objects, one for each word in the transcript.<br/>
        /// See [Speech recognition](https://www.assemblyai.com/docs/models/speech-recognition) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("words")]
        public global::System.Collections.Generic.IList<global::G.TranscriptWord>? Words { get; set; }

        /// <summary>
        /// When dual_channel or speaker_labels is enabled, a list of turn-by-turn utterance objects.<br/>
        /// See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("utterances")]
        public global::System.Collections.Generic.IList<global::G.TranscriptUtterance>? Utterances { get; set; }

        /// <summary>
        /// The confidence score for the transcript, between 0.0 (low confidence) and 1.0 (high confidence)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The duration of this transcript object's media file, in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_duration")]
        public object? AudioDuration { get; set; }

        /// <summary>
        /// Whether Automatic Punctuation is enabled, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("punctuate")]
        public object? Punctuate { get; set; }

        /// <summary>
        /// Whether Text Formatting is enabled, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format_text")]
        public object? FormatText { get; set; }

        /// <summary>
        /// Transcribe Filler Words, like "umm", in your media file; can be true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disfluencies")]
        public object? Disfluencies { get; set; }

        /// <summary>
        /// Whether [Dual channel transcription](https://www.assemblyai.com/docs/models/speech-recognition#dual-channel-transcription) was enabled in the transcription request, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dual_channel")]
        public object? DualChannel { get; set; }

        /// <summary>
        /// The URL to which we send webhook requests.<br/>
        /// We sends two different types of webhook requests.<br/>
        /// One request when a transcript is completed or failed, and one request when the redacted audio is ready if redact_pii_audio is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// The status code we received from your server when delivering the transcript completed or failed webhook request, if a webhook URL was provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_status_code")]
        public object? WebhookStatusCode { get; set; }

        /// <summary>
        /// Whether webhook authentication details were provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_auth", Required = global::Newtonsoft.Json.Required.Always)]
        public bool WebhookAuth { get; set; } = default!;

        /// <summary>
        /// The header name to be sent with the transcript completed or failed webhook requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_auth_header_name")]
        public object? WebhookAuthHeaderName { get; set; }

        /// <summary>
        /// Whether speed boost is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed_boost")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public object? SpeedBoost { get; set; }

        /// <summary>
        /// Whether Key Phrases is enabled, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_highlights", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AutoHighlights { get; set; } = default!;

        /// <summary>
        /// An array of results for the Key Phrases model, if it is enabled.<br/>
        /// See [Key Phrases](https://www.assemblyai.com/docs/models/key-phrases) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_highlights_result")]
        public global::G.OneOf<global::G.AutoHighlightsResult2, object>? AutoHighlightsResult { get; set; }

        /// <summary>
        /// The point in time, in milliseconds, in the file at which the transcription was started
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_start_from")]
        public object? AudioStartFrom { get; set; }

        /// <summary>
        /// The point in time, in milliseconds, in the file at which the transcription was terminated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_end_at")]
        public object? AudioEndAt { get; set; }

        /// <summary>
        /// The list of custom vocabulary to boost transcription probability for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word_boost")]
        public global::System.Collections.Generic.IList<string>? WordBoost { get; set; }

        /// <summary>
        /// The word boost parameter value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("boost_param")]
        public object? BoostParam { get; set; }

        /// <summary>
        /// Whether [Profanity Filtering](https://www.assemblyai.com/docs/models/speech-recognition#profanity-filtering) is enabled, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter_profanity")]
        public object? FilterProfanity { get; set; }

        /// <summary>
        /// Whether [PII Redaction](https://www.assemblyai.com/docs/models/pii-redaction) is enabled, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redact_pii", Required = global::Newtonsoft.Json.Required.Always)]
        public bool RedactPii { get; set; } = default!;

        /// <summary>
        /// Whether a redacted version of the audio file was generated,<br/>
        /// either true or false. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redact_pii_audio")]
        public object? RedactPiiAudio { get; set; }

        /// <summary>
        /// The audio quality of the PII-redacted audio file, if redact_pii_audio is enabled.<br/>
        /// See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redact_pii_audio_quality")]
        public global::G.OneOf<global::G.RedactPiiAudioQuality?, object>? RedactPiiAudioQuality { get; set; }

        /// <summary>
        /// The list of PII Redaction policies that were enabled, if PII Redaction is enabled.<br/>
        /// See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redact_pii_policies")]
        public global::System.Collections.Generic.IList<global::G.PiiPolicy>? RedactPiiPolicies { get; set; }

        /// <summary>
        /// The replacement logic for detected PII, can be "entity_name" or "hash". See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redact_pii_sub")]
        public global::G.SubstitutionPolicy? RedactPiiSub { get; set; }

        /// <summary>
        /// Whether [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, can be true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_labels")]
        public object? SpeakerLabels { get; set; }

        /// <summary>
        /// Tell the speaker label model how many speakers it should attempt to identify, up to 10. See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speakers_expected")]
        public object? SpeakersExpected { get; set; }

        /// <summary>
        /// Whether [Content Moderation](https://www.assemblyai.com/docs/models/content-moderation) is enabled, can be true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_safety")]
        public object? ContentSafety { get; set; }

        /// <summary>
        /// An array of results for the Content Moderation model, if it is enabled.<br/>
        /// See [Content moderation](https://www.assemblyai.com/docs/models/content-moderation) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_safety_labels")]
        public global::G.OneOf<global::G.ContentSafetyLabelsResult, object>? ContentSafetyLabels { get; set; }

        /// <summary>
        /// Whether [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection) is enabled, can be true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("iab_categories")]
        public object? IabCategories { get; set; }

        /// <summary>
        /// The result of the Topic Detection model, if it is enabled.<br/>
        /// See [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("iab_categories_result")]
        public global::G.OneOf<global::G.TopicDetectionModelResult, object>? IabCategoriesResult { get; set; }

        /// <summary>
        /// Customize how words are spelled and formatted using to and from values
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_spelling")]
        public global::System.Collections.Generic.IList<global::G.TranscriptCustomSpelling>? CustomSpelling { get; set; }

        /// <summary>
        /// Whether [Auto Chapters](https://www.assemblyai.com/docs/models/auto-chapters) is enabled, can be true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_chapters")]
        public object? AutoChapters { get; set; }

        /// <summary>
        /// An array of temporally sequential chapters for the audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chapters")]
        public global::System.Collections.Generic.IList<global::G.Chapter>? Chapters { get; set; }

        /// <summary>
        /// Whether [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summarization", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Summarization { get; set; } = default!;

        /// <summary>
        /// The type of summary generated, if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_type")]
        public object? SummaryType { get; set; }

        /// <summary>
        /// The Summarization model used to generate the summary,<br/>
        /// if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_model")]
        public object? SummaryModel { get; set; }

        /// <summary>
        /// The generated summary of the media file, if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public object? Summary { get; set; }

        /// <summary>
        /// Whether custom topics is enabled, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_topics")]
        public object? CustomTopics { get; set; }

        /// <summary>
        /// The list of custom topics provided if custom topics is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topics")]
        public global::System.Collections.Generic.IList<string>? Topics { get; set; }

        /// <summary>
        /// Whether [Sentiment Analysis](https://www.assemblyai.com/docs/models/sentiment-analysis) is enabled, can be true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiment_analysis")]
        public object? SentimentAnalysis { get; set; }

        /// <summary>
        /// An array of results for the Sentiment Analysis model, if it is enabled.<br/>
        /// See [Sentiment Analysis](https://www.assemblyai.com/docs/models/sentiment-analysis) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiment_analysis_results")]
        public global::System.Collections.Generic.IList<global::G.SentimentAnalysisResult>? SentimentAnalysisResults { get; set; }

        /// <summary>
        /// Whether [Entity Detection](https://www.assemblyai.com/docs/models/entity-detection) is enabled, can be true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_detection")]
        public object? EntityDetection { get; set; }

        /// <summary>
        /// An array of results for the Entity Detection model, if it is enabled.<br/>
        /// See [Entity detection](https://www.assemblyai.com/docs/models/entity-detection) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entities")]
        public global::System.Collections.Generic.IList<global::G.Entity>? Entities { get; set; }

        /// <summary>
        /// Defaults to null. Reject audio files that contain less than this fraction of speech.<br/>
        /// Valid values are in the range [0, 1] inclusive.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speech_threshold")]
        public float? SpeechThreshold { get; set; }

        /// <summary>
        /// True while a request is throttled and false when a request is no longer throttled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("throttled")]
        public object? Throttled { get; set; }

        /// <summary>
        /// Error message of why the transcript failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The language model that was used for the transcript
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_model", Required = global::Newtonsoft.Json.Required.Always)]
        public string LanguageModel { get; set; } = default!;

        /// <summary>
        /// The acoustic model that was used for the transcript
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("acoustic_model", Required = global::Newtonsoft.Json.Required.Always)]
        public string AcousticModel { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcript" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of your transcript
        /// </param>
        /// <param name="audioUrl">
        /// The URL of the media that was transcribed
        /// </param>
        /// <param name="status">
        /// The status of your transcript. Possible values are queued, processing, completed, or error.
        /// </param>
        /// <param name="languageCode">
        /// The language of your audio file.<br/>
        /// Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/concepts/supported-languages).<br/>
        /// The default value is 'en_us'.
        /// </param>
        /// <param name="languageDetection">
        /// Whether [Automatic language detection](https://www.assemblyai.com/docs/models/speech-recognition#automatic-language-detection) is enabled, either true or false
        /// </param>
        /// <param name="languageConfidenceThreshold">
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.
        /// </param>
        /// <param name="languageConfidence">
        /// The confidence score for the detected language, between 0.0 (low confidence) and 1.0 (high confidence)
        /// </param>
        /// <param name="speechModel">
        /// The speech model used for the transcription. When `null`, the default model is used.
        /// </param>
        /// <param name="text">
        /// The textual transcript of your media file
        /// </param>
        /// <param name="words">
        /// An array of temporally-sequential word objects, one for each word in the transcript.<br/>
        /// See [Speech recognition](https://www.assemblyai.com/docs/models/speech-recognition) for more information.
        /// </param>
        /// <param name="utterances">
        /// When dual_channel or speaker_labels is enabled, a list of turn-by-turn utterance objects.<br/>
        /// See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more information.
        /// </param>
        /// <param name="confidence">
        /// The confidence score for the transcript, between 0.0 (low confidence) and 1.0 (high confidence)
        /// </param>
        /// <param name="audioDuration">
        /// The duration of this transcript object's media file, in seconds
        /// </param>
        /// <param name="punctuate">
        /// Whether Automatic Punctuation is enabled, either true or false
        /// </param>
        /// <param name="formatText">
        /// Whether Text Formatting is enabled, either true or false
        /// </param>
        /// <param name="disfluencies">
        /// Transcribe Filler Words, like "umm", in your media file; can be true or false
        /// </param>
        /// <param name="dualChannel">
        /// Whether [Dual channel transcription](https://www.assemblyai.com/docs/models/speech-recognition#dual-channel-transcription) was enabled in the transcription request, either true or false
        /// </param>
        /// <param name="webhookUrl">
        /// The URL to which we send webhook requests.<br/>
        /// We sends two different types of webhook requests.<br/>
        /// One request when a transcript is completed or failed, and one request when the redacted audio is ready if redact_pii_audio is enabled.
        /// </param>
        /// <param name="webhookStatusCode">
        /// The status code we received from your server when delivering the transcript completed or failed webhook request, if a webhook URL was provided
        /// </param>
        /// <param name="webhookAuth">
        /// Whether webhook authentication details were provided
        /// </param>
        /// <param name="webhookAuthHeaderName">
        /// The header name to be sent with the transcript completed or failed webhook requests
        /// </param>
        /// <param name="autoHighlights">
        /// Whether Key Phrases is enabled, either true or false
        /// </param>
        /// <param name="autoHighlightsResult">
        /// An array of results for the Key Phrases model, if it is enabled.<br/>
        /// See [Key Phrases](https://www.assemblyai.com/docs/models/key-phrases) for more information.
        /// </param>
        /// <param name="audioStartFrom">
        /// The point in time, in milliseconds, in the file at which the transcription was started
        /// </param>
        /// <param name="audioEndAt">
        /// The point in time, in milliseconds, in the file at which the transcription was terminated
        /// </param>
        /// <param name="wordBoost">
        /// The list of custom vocabulary to boost transcription probability for
        /// </param>
        /// <param name="boostParam">
        /// The word boost parameter value
        /// </param>
        /// <param name="filterProfanity">
        /// Whether [Profanity Filtering](https://www.assemblyai.com/docs/models/speech-recognition#profanity-filtering) is enabled, either true or false
        /// </param>
        /// <param name="redactPii">
        /// Whether [PII Redaction](https://www.assemblyai.com/docs/models/pii-redaction) is enabled, either true or false
        /// </param>
        /// <param name="redactPiiAudio">
        /// Whether a redacted version of the audio file was generated,<br/>
        /// either true or false. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more information.
        /// </param>
        /// <param name="redactPiiAudioQuality">
        /// The audio quality of the PII-redacted audio file, if redact_pii_audio is enabled.<br/>
        /// See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more information.
        /// </param>
        /// <param name="redactPiiPolicies">
        /// The list of PII Redaction policies that were enabled, if PII Redaction is enabled.<br/>
        /// See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more information.
        /// </param>
        /// <param name="redactPiiSub">
        /// The replacement logic for detected PII, can be "entity_name" or "hash". See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.
        /// </param>
        /// <param name="speakerLabels">
        /// Whether [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, can be true or false
        /// </param>
        /// <param name="speakersExpected">
        /// Tell the speaker label model how many speakers it should attempt to identify, up to 10. See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more details.
        /// </param>
        /// <param name="contentSafety">
        /// Whether [Content Moderation](https://www.assemblyai.com/docs/models/content-moderation) is enabled, can be true or false
        /// </param>
        /// <param name="contentSafetyLabels">
        /// An array of results for the Content Moderation model, if it is enabled.<br/>
        /// See [Content moderation](https://www.assemblyai.com/docs/models/content-moderation) for more information.
        /// </param>
        /// <param name="iabCategories">
        /// Whether [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection) is enabled, can be true or false
        /// </param>
        /// <param name="iabCategoriesResult">
        /// The result of the Topic Detection model, if it is enabled.<br/>
        /// See [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection) for more information.
        /// </param>
        /// <param name="customSpelling">
        /// Customize how words are spelled and formatted using to and from values
        /// </param>
        /// <param name="autoChapters">
        /// Whether [Auto Chapters](https://www.assemblyai.com/docs/models/auto-chapters) is enabled, can be true or false
        /// </param>
        /// <param name="chapters">
        /// An array of temporally sequential chapters for the audio file
        /// </param>
        /// <param name="summarization">
        /// Whether [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled, either true or false
        /// </param>
        /// <param name="summaryType">
        /// The type of summary generated, if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </param>
        /// <param name="summaryModel">
        /// The Summarization model used to generate the summary,<br/>
        /// if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </param>
        /// <param name="summary">
        /// The generated summary of the media file, if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </param>
        /// <param name="customTopics">
        /// Whether custom topics is enabled, either true or false
        /// </param>
        /// <param name="topics">
        /// The list of custom topics provided if custom topics is enabled
        /// </param>
        /// <param name="sentimentAnalysis">
        /// Whether [Sentiment Analysis](https://www.assemblyai.com/docs/models/sentiment-analysis) is enabled, can be true or false
        /// </param>
        /// <param name="sentimentAnalysisResults">
        /// An array of results for the Sentiment Analysis model, if it is enabled.<br/>
        /// See [Sentiment Analysis](https://www.assemblyai.com/docs/models/sentiment-analysis) for more information.
        /// </param>
        /// <param name="entityDetection">
        /// Whether [Entity Detection](https://www.assemblyai.com/docs/models/entity-detection) is enabled, can be true or false
        /// </param>
        /// <param name="entities">
        /// An array of results for the Entity Detection model, if it is enabled.<br/>
        /// See [Entity detection](https://www.assemblyai.com/docs/models/entity-detection) for more information.
        /// </param>
        /// <param name="speechThreshold">
        /// Defaults to null. Reject audio files that contain less than this fraction of speech.<br/>
        /// Valid values are in the range [0, 1] inclusive.
        /// </param>
        /// <param name="throttled">
        /// True while a request is throttled and false when a request is no longer throttled
        /// </param>
        /// <param name="error">
        /// Error message of why the transcript failed
        /// </param>
        public Transcript(
            global::System.Guid id,
            string audioUrl,
            global::G.TranscriptStatus status,
            float languageConfidenceThreshold,
            double languageConfidence,
            global::G.OneOf<global::G.SpeechModel2?, object> speechModel,
            bool webhookAuth,
            bool autoHighlights,
            bool redactPii,
            bool summarization,
            string languageModel,
            string acousticModel,
            global::G.AnyOf<global::G.TranscriptLanguageCode?, string>? languageCode,
            object? languageDetection,
            object? text,
            global::System.Collections.Generic.IList<global::G.TranscriptWord>? words,
            global::System.Collections.Generic.IList<global::G.TranscriptUtterance>? utterances,
            double? confidence,
            object? audioDuration,
            object? punctuate,
            object? formatText,
            object? disfluencies,
            object? dualChannel,
            string? webhookUrl,
            object? webhookStatusCode,
            object? webhookAuthHeaderName,
            global::G.OneOf<global::G.AutoHighlightsResult2, object>? autoHighlightsResult,
            object? audioStartFrom,
            object? audioEndAt,
            global::System.Collections.Generic.IList<string>? wordBoost,
            object? boostParam,
            object? filterProfanity,
            object? redactPiiAudio,
            global::G.OneOf<global::G.RedactPiiAudioQuality?, object>? redactPiiAudioQuality,
            global::System.Collections.Generic.IList<global::G.PiiPolicy>? redactPiiPolicies,
            global::G.SubstitutionPolicy? redactPiiSub,
            object? speakerLabels,
            object? speakersExpected,
            object? contentSafety,
            global::G.OneOf<global::G.ContentSafetyLabelsResult, object>? contentSafetyLabels,
            object? iabCategories,
            global::G.OneOf<global::G.TopicDetectionModelResult, object>? iabCategoriesResult,
            global::System.Collections.Generic.IList<global::G.TranscriptCustomSpelling>? customSpelling,
            object? autoChapters,
            global::System.Collections.Generic.IList<global::G.Chapter>? chapters,
            object? summaryType,
            object? summaryModel,
            object? summary,
            object? customTopics,
            global::System.Collections.Generic.IList<string>? topics,
            object? sentimentAnalysis,
            global::System.Collections.Generic.IList<global::G.SentimentAnalysisResult>? sentimentAnalysisResults,
            object? entityDetection,
            global::System.Collections.Generic.IList<global::G.Entity>? entities,
            float? speechThreshold,
            object? throttled,
            string? error)
        {
            this.Id = id;
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
            this.Status = status;
            this.LanguageConfidenceThreshold = languageConfidenceThreshold;
            this.LanguageConfidence = languageConfidence;
            this.SpeechModel = speechModel;
            this.WebhookAuth = webhookAuth;
            this.AutoHighlights = autoHighlights;
            this.RedactPii = redactPii;
            this.Summarization = summarization;
            this.LanguageModel = languageModel ?? throw new global::System.ArgumentNullException(nameof(languageModel));
            this.AcousticModel = acousticModel ?? throw new global::System.ArgumentNullException(nameof(acousticModel));
            this.LanguageCode = languageCode;
            this.LanguageDetection = languageDetection;
            this.Text = text;
            this.Words = words;
            this.Utterances = utterances;
            this.Confidence = confidence;
            this.AudioDuration = audioDuration;
            this.Punctuate = punctuate;
            this.FormatText = formatText;
            this.Disfluencies = disfluencies;
            this.DualChannel = dualChannel;
            this.WebhookUrl = webhookUrl;
            this.WebhookStatusCode = webhookStatusCode;
            this.WebhookAuthHeaderName = webhookAuthHeaderName;
            this.AutoHighlightsResult = autoHighlightsResult;
            this.AudioStartFrom = audioStartFrom;
            this.AudioEndAt = audioEndAt;
            this.WordBoost = wordBoost;
            this.BoostParam = boostParam;
            this.FilterProfanity = filterProfanity;
            this.RedactPiiAudio = redactPiiAudio;
            this.RedactPiiAudioQuality = redactPiiAudioQuality;
            this.RedactPiiPolicies = redactPiiPolicies;
            this.RedactPiiSub = redactPiiSub;
            this.SpeakerLabels = speakerLabels;
            this.SpeakersExpected = speakersExpected;
            this.ContentSafety = contentSafety;
            this.ContentSafetyLabels = contentSafetyLabels;
            this.IabCategories = iabCategories;
            this.IabCategoriesResult = iabCategoriesResult;
            this.CustomSpelling = customSpelling;
            this.AutoChapters = autoChapters;
            this.Chapters = chapters;
            this.SummaryType = summaryType;
            this.SummaryModel = summaryModel;
            this.Summary = summary;
            this.CustomTopics = customTopics;
            this.Topics = topics;
            this.SentimentAnalysis = sentimentAnalysis;
            this.SentimentAnalysisResults = sentimentAnalysisResults;
            this.EntityDetection = entityDetection;
            this.Entities = entities;
            this.SpeechThreshold = speechThreshold;
            this.Throttled = throttled;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcript" /> class.
        /// </summary>
        public Transcript()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Transcript? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Transcript>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.Transcript?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Transcript?>(serializer.Deserialize<global::G.Transcript>(jsonReader));
        }

    }
}