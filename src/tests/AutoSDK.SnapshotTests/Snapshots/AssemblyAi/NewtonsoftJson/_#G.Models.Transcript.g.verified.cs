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
        public global::G.TranscriptLanguageDetection? LanguageDetection { get; set; }

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
        public global::G.TranscriptText? Text { get; set; }

        /// <summary>
        /// An array of temporally-sequential word objects, one for each word in the transcript.<br/>
        /// See [Speech recognition](https://www.assemblyai.com/docs/models/speech-recognition) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("words")]
        public global::G.TranscriptWords? Words { get; set; }

        /// <summary>
        /// When dual_channel or speaker_labels is enabled, a list of turn-by-turn utterance objects.<br/>
        /// See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("utterances")]
        public global::G.TranscriptUtterances? Utterances { get; set; }

        /// <summary>
        /// The confidence score for the transcript, between 0.0 (low confidence) and 1.0 (high confidence)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The duration of this transcript object's media file, in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_duration")]
        public global::G.TranscriptAudioDuration? AudioDuration { get; set; }

        /// <summary>
        /// Whether Automatic Punctuation is enabled, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("punctuate")]
        public global::G.TranscriptPunctuate? Punctuate { get; set; }

        /// <summary>
        /// Whether Text Formatting is enabled, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format_text")]
        public global::G.TranscriptFormatText? FormatText { get; set; }

        /// <summary>
        /// Transcribe Filler Words, like "umm", in your media file; can be true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disfluencies")]
        public global::G.TranscriptDisfluencies? Disfluencies { get; set; }

        /// <summary>
        /// Whether [Dual channel transcription](https://www.assemblyai.com/docs/models/speech-recognition#dual-channel-transcription) was enabled in the transcription request, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dual_channel")]
        public global::G.TranscriptDualChannel? DualChannel { get; set; }

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
        public global::G.TranscriptWebhookStatusCode? WebhookStatusCode { get; set; }

        /// <summary>
        /// Whether webhook authentication details were provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_auth", Required = global::Newtonsoft.Json.Required.Always)]
        public bool WebhookAuth { get; set; } = default!;

        /// <summary>
        /// The header name to be sent with the transcript completed or failed webhook requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_auth_header_name")]
        public global::G.TranscriptWebhookAuthHeaderName? WebhookAuthHeaderName { get; set; }

        /// <summary>
        /// Whether speed boost is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed_boost")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.TranscriptSpeedBoost? SpeedBoost { get; set; }

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
        public global::G.TranscriptAudioStartFrom? AudioStartFrom { get; set; }

        /// <summary>
        /// The point in time, in milliseconds, in the file at which the transcription was terminated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_end_at")]
        public global::G.TranscriptAudioEndAt? AudioEndAt { get; set; }

        /// <summary>
        /// The list of custom vocabulary to boost transcription probability for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word_boost")]
        public global::System.Collections.Generic.IList<string>? WordBoost { get; set; }

        /// <summary>
        /// The word boost parameter value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("boost_param")]
        public global::G.TranscriptBoostParam2? BoostParam { get; set; }

        /// <summary>
        /// Whether [Profanity Filtering](https://www.assemblyai.com/docs/models/speech-recognition#profanity-filtering) is enabled, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter_profanity")]
        public global::G.TranscriptFilterProfanity? FilterProfanity { get; set; }

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
        public global::G.TranscriptRedactPiiAudio? RedactPiiAudio { get; set; }

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
        public global::G.TranscriptRedactPiiPolicies? RedactPiiPolicies { get; set; }

        /// <summary>
        /// The replacement logic for detected PII, can be "entity_name" or "hash". See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("redact_pii_sub")]
        public global::G.SubstitutionPolicy? RedactPiiSub { get; set; }

        /// <summary>
        /// Whether [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) is enabled, can be true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker_labels")]
        public global::G.TranscriptSpeakerLabels? SpeakerLabels { get; set; }

        /// <summary>
        /// Tell the speaker label model how many speakers it should attempt to identify, up to 10. See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speakers_expected")]
        public global::G.TranscriptSpeakersExpected? SpeakersExpected { get; set; }

        /// <summary>
        /// Whether [Content Moderation](https://www.assemblyai.com/docs/models/content-moderation) is enabled, can be true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_safety")]
        public global::G.TranscriptContentSafety? ContentSafety { get; set; }

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
        public global::G.TranscriptIabCategories? IabCategories { get; set; }

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
        public global::G.TranscriptCustomSpelling2? CustomSpelling { get; set; }

        /// <summary>
        /// Whether [Auto Chapters](https://www.assemblyai.com/docs/models/auto-chapters) is enabled, can be true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_chapters")]
        public global::G.TranscriptAutoChapters? AutoChapters { get; set; }

        /// <summary>
        /// An array of temporally sequential chapters for the audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chapters")]
        public global::G.TranscriptChapters? Chapters { get; set; }

        /// <summary>
        /// Whether [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summarization", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Summarization { get; set; } = default!;

        /// <summary>
        /// The type of summary generated, if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_type")]
        public global::G.TranscriptSummaryType? SummaryType { get; set; }

        /// <summary>
        /// The Summarization model used to generate the summary,<br/>
        /// if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary_model")]
        public global::G.TranscriptSummaryModel? SummaryModel { get; set; }

        /// <summary>
        /// The generated summary of the media file, if [Summarization](https://www.assemblyai.com/docs/models/summarization) is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public global::G.TranscriptSummary? Summary { get; set; }

        /// <summary>
        /// Whether custom topics is enabled, either true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_topics")]
        public global::G.TranscriptCustomTopics? CustomTopics { get; set; }

        /// <summary>
        /// The list of custom topics provided if custom topics is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topics")]
        public global::System.Collections.Generic.IList<string>? Topics { get; set; }

        /// <summary>
        /// Whether [Sentiment Analysis](https://www.assemblyai.com/docs/models/sentiment-analysis) is enabled, can be true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiment_analysis")]
        public global::G.TranscriptSentimentAnalysis? SentimentAnalysis { get; set; }

        /// <summary>
        /// An array of results for the Sentiment Analysis model, if it is enabled.<br/>
        /// See [Sentiment Analysis](https://www.assemblyai.com/docs/models/sentiment-analysis) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiment_analysis_results")]
        public global::G.TranscriptSentimentAnalysisResults? SentimentAnalysisResults { get; set; }

        /// <summary>
        /// Whether [Entity Detection](https://www.assemblyai.com/docs/models/entity-detection) is enabled, can be true or false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_detection")]
        public global::G.TranscriptEntityDetection? EntityDetection { get; set; }

        /// <summary>
        /// An array of results for the Entity Detection model, if it is enabled.<br/>
        /// See [Entity detection](https://www.assemblyai.com/docs/models/entity-detection) for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entities")]
        public global::G.TranscriptEntities? Entities { get; set; }

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
        public global::G.TranscriptThrottled? Throttled { get; set; }

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
    }
}