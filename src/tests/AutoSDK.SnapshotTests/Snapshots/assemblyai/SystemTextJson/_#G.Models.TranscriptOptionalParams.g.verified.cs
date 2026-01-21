//HintName: G.Models.TranscriptOptionalParams.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The parameters for creating a transcript<br/>
    /// Example: {"speech_model":"","language_code":"en_us","language_detection":true,"language_confidence_threshold":0.7,"punctuate":true,"format_text":true,"dual_channel":true,"webhook_url":"https://your-webhook-url.tld/path","webhook_auth_header_name":"webhook-secret","webhook_auth_header_value":"webhook-secret-value","auto_highlights":true,"audio_start_from":10,"audio_end_at":280,"word_boost":["aws","azure","google cloud"],"boost_param":"high","filter_profanity":true,"redact_pii":true,"redact_pii_audio":true,"redact_pii_audio_quality":"mp3","redact_pii_policies":["us_social_security_number","credit_card_number"],"redact_pii_sub":"hash","speaker_labels":true,"speakers_expected":2,"content_safety":true,"iab_categories":true,"custom_spelling":[],"disfluencies":false,"sentiment_analysis":true,"auto_chapters":true,"entity_detection":true,"speech_threshold":0.5,"summarization":true,"summary_model":"informative","summary_type":"bullets","custom_topics":true,"topics":[]}
    /// </summary>
    public sealed partial class TranscriptOptionalParams
    {
        /// <summary>
        /// The language of your audio file. Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/concepts/supported-languages).<br/>
        /// The default value is 'en_us'.<br/>
        /// Default Value: en_us
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.AnyOf<global::G.TranscriptLanguageCode?, string>?, object>))]
        public global::G.OneOf<global::G.AnyOf<global::G.TranscriptLanguageCode?, string>?, object>? LanguageCode { get; set; }

        /// <summary>
        /// Enable [Automatic language detection](https://www.assemblyai.com/docs/models/speech-recognition#automatic-language-detection), either true or false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection")]
        public bool? LanguageDetection { get; set; }

        /// <summary>
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.<br/>
        /// Defaults to 0.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_confidence_threshold")]
        public float? LanguageConfidenceThreshold { get; set; }

        /// <summary>
        /// The speech model to use for the transcription. When `null`, the "best" model is used.<br/>
        /// Default Value: best
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.SpeechModel2?, object>))]
        public global::G.OneOf<global::G.SpeechModel2?, object>? SpeechModel { get; set; }

        /// <summary>
        /// Enable Automatic Punctuation, can be true or false<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("punctuate")]
        public bool? Punctuate { get; set; }

        /// <summary>
        /// Enable Text Formatting, can be true or false<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format_text")]
        public bool? FormatText { get; set; }

        /// <summary>
        /// Transcribe Filler Words, like "umm", in your media file; can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disfluencies")]
        public bool? Disfluencies { get; set; }

        /// <summary>
        /// Enable [Dual Channel](https://www.assemblyai.com/docs/models/speech-recognition#dual-channel-transcription) transcription, can be true or false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dual_channel")]
        public bool? DualChannel { get; set; }

        /// <summary>
        /// The URL to which we send webhook requests.<br/>
        /// We sends two different types of webhook requests.<br/>
        /// One request when a transcript is completed or failed, and one request when the redacted audio is ready if redact_pii_audio is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// The header name to be sent with the transcript completed or failed webhook requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_auth_header_name")]
        public object? WebhookAuthHeaderName { get; set; }

        /// <summary>
        /// The header value to send back with the transcript completed or failed webhook requests for added security
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_auth_header_value")]
        public object? WebhookAuthHeaderValue { get; set; }

        /// <summary>
        /// Enable Key Phrases, either true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_highlights")]
        public bool? AutoHighlights { get; set; }

        /// <summary>
        /// The point in time, in milliseconds, to begin transcribing in your media file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_start_from")]
        public int? AudioStartFrom { get; set; }

        /// <summary>
        /// The point in time, in milliseconds, to stop transcribing in your media file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_at")]
        public int? AudioEndAt { get; set; }

        /// <summary>
        /// The list of custom vocabulary to boost transcription probability for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_boost")]
        public global::System.Collections.Generic.IList<string>? WordBoost { get; set; }

        /// <summary>
        /// How much to boost specified words
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("boost_param")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscriptBoostParamJsonConverter))]
        public global::G.TranscriptBoostParam? BoostParam { get; set; }

        /// <summary>
        /// Filter profanity from the transcribed text, can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_profanity")]
        public bool? FilterProfanity { get; set; }

        /// <summary>
        /// Redact PII from the transcribed text using the Redact PII model, can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii")]
        public bool? RedactPii { get; set; }

        /// <summary>
        /// Generate a copy of the original media file with spoken PII "beeped" out, can be true or false. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_audio")]
        public bool? RedactPiiAudio { get; set; }

        /// <summary>
        /// Controls the filetype of the audio created by redact_pii_audio. Currently supports mp3 (default) and wav. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.<br/>
        /// Example: mp3
        /// </summary>
        /// <example>mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_audio_quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RedactPiiAudioQualityJsonConverter))]
        public global::G.RedactPiiAudioQuality? RedactPiiAudioQuality { get; set; }

        /// <summary>
        /// The list of PII Redaction policies to enable. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_policies")]
        public global::System.Collections.Generic.IList<global::G.PiiPolicy>? RedactPiiPolicies { get; set; }

        /// <summary>
        /// The replacement logic for detected PII, can be "entity_type" or "hash". See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.<br/>
        /// Default Value: hash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redact_pii_sub")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.SubstitutionPolicy?, object>))]
        public global::G.OneOf<global::G.SubstitutionPolicy?, object>? RedactPiiSub { get; set; }

        /// <summary>
        /// Enable [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_labels")]
        public bool? SpeakerLabels { get; set; }

        /// <summary>
        /// Tells the speaker label model how many speakers it should attempt to identify, up to 10. See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakers_expected")]
        public object? SpeakersExpected { get; set; }

        /// <summary>
        /// Enable [Content Moderation](https://www.assemblyai.com/docs/models/content-moderation), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_safety")]
        public bool? ContentSafety { get; set; }

        /// <summary>
        /// The confidence threshold for the Content Moderation model. Values must be between 25 and 100.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_safety_confidence")]
        public int? ContentSafetyConfidence { get; set; }

        /// <summary>
        /// Enable [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iab_categories")]
        public bool? IabCategories { get; set; }

        /// <summary>
        /// Customize how words are spelled and formatted using to and from values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_spelling")]
        public global::System.Collections.Generic.IList<global::G.TranscriptCustomSpelling>? CustomSpelling { get; set; }

        /// <summary>
        /// Enable [Sentiment Analysis](https://www.assemblyai.com/docs/models/sentiment-analysis), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis")]
        public bool? SentimentAnalysis { get; set; }

        /// <summary>
        /// Enable [Auto Chapters](https://www.assemblyai.com/docs/models/auto-chapters), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_chapters")]
        public bool? AutoChapters { get; set; }

        /// <summary>
        /// Enable [Entity Detection](https://www.assemblyai.com/docs/models/entity-detection), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_detection")]
        public bool? EntityDetection { get; set; }

        /// <summary>
        /// Reject audio files that contain less than this fraction of speech.<br/>
        /// Valid values are in the range [0, 1] inclusive.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_threshold")]
        public float? SpeechThreshold { get; set; }

        /// <summary>
        /// Enable [Summarization](https://www.assemblyai.com/docs/models/summarization), can be true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarization")]
        public bool? Summarization { get; set; }

        /// <summary>
        /// The model to summarize the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SummaryModelJsonConverter))]
        public global::G.SummaryModel? SummaryModel { get; set; }

        /// <summary>
        /// The type of summary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SummaryTypeJsonConverter))]
        public global::G.SummaryType? SummaryType { get; set; }

        /// <summary>
        /// Enable custom topics, either true or false<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_topics")]
        public bool? CustomTopics { get; set; }

        /// <summary>
        /// The list of custom topics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<string>? Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOptionalParams" /> class.
        /// </summary>
        /// <param name="languageCode">
        /// The language of your audio file. Possible values are found in [Supported Languages](https://www.assemblyai.com/docs/concepts/supported-languages).<br/>
        /// The default value is 'en_us'.<br/>
        /// Default Value: en_us
        /// </param>
        /// <param name="languageDetection">
        /// Enable [Automatic language detection](https://www.assemblyai.com/docs/models/speech-recognition#automatic-language-detection), either true or false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="languageConfidenceThreshold">
        /// The confidence threshold for the automatically detected language.<br/>
        /// An error will be returned if the language confidence is below this threshold.<br/>
        /// Defaults to 0.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="speechModel">
        /// The speech model to use for the transcription. When `null`, the "best" model is used.<br/>
        /// Default Value: best
        /// </param>
        /// <param name="punctuate">
        /// Enable Automatic Punctuation, can be true or false<br/>
        /// Default Value: true
        /// </param>
        /// <param name="formatText">
        /// Enable Text Formatting, can be true or false<br/>
        /// Default Value: true
        /// </param>
        /// <param name="disfluencies">
        /// Transcribe Filler Words, like "umm", in your media file; can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dualChannel">
        /// Enable [Dual Channel](https://www.assemblyai.com/docs/models/speech-recognition#dual-channel-transcription) transcription, can be true or false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// The URL to which we send webhook requests.<br/>
        /// We sends two different types of webhook requests.<br/>
        /// One request when a transcript is completed or failed, and one request when the redacted audio is ready if redact_pii_audio is enabled.
        /// </param>
        /// <param name="webhookAuthHeaderName">
        /// The header name to be sent with the transcript completed or failed webhook requests
        /// </param>
        /// <param name="webhookAuthHeaderValue">
        /// The header value to send back with the transcript completed or failed webhook requests for added security
        /// </param>
        /// <param name="autoHighlights">
        /// Enable Key Phrases, either true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="audioStartFrom">
        /// The point in time, in milliseconds, to begin transcribing in your media file
        /// </param>
        /// <param name="audioEndAt">
        /// The point in time, in milliseconds, to stop transcribing in your media file
        /// </param>
        /// <param name="wordBoost">
        /// The list of custom vocabulary to boost transcription probability for
        /// </param>
        /// <param name="boostParam">
        /// How much to boost specified words
        /// </param>
        /// <param name="filterProfanity">
        /// Filter profanity from the transcribed text, can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="redactPii">
        /// Redact PII from the transcribed text using the Redact PII model, can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="redactPiiAudio">
        /// Generate a copy of the original media file with spoken PII "beeped" out, can be true or false. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="redactPiiAudioQuality">
        /// Controls the filetype of the audio created by redact_pii_audio. Currently supports mp3 (default) and wav. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.<br/>
        /// Example: mp3
        /// </param>
        /// <param name="redactPiiPolicies">
        /// The list of PII Redaction policies to enable. See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.
        /// </param>
        /// <param name="redactPiiSub">
        /// The replacement logic for detected PII, can be "entity_type" or "hash". See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.<br/>
        /// Default Value: hash
        /// </param>
        /// <param name="speakerLabels">
        /// Enable [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speakersExpected">
        /// Tells the speaker label model how many speakers it should attempt to identify, up to 10. See [Speaker diarization](https://www.assemblyai.com/docs/models/speaker-diarization) for more details.
        /// </param>
        /// <param name="contentSafety">
        /// Enable [Content Moderation](https://www.assemblyai.com/docs/models/content-moderation), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="contentSafetyConfidence">
        /// The confidence threshold for the Content Moderation model. Values must be between 25 and 100.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="iabCategories">
        /// Enable [Topic Detection](https://www.assemblyai.com/docs/models/topic-detection), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="customSpelling">
        /// Customize how words are spelled and formatted using to and from values
        /// </param>
        /// <param name="sentimentAnalysis">
        /// Enable [Sentiment Analysis](https://www.assemblyai.com/docs/models/sentiment-analysis), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoChapters">
        /// Enable [Auto Chapters](https://www.assemblyai.com/docs/models/auto-chapters), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="entityDetection">
        /// Enable [Entity Detection](https://www.assemblyai.com/docs/models/entity-detection), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="speechThreshold">
        /// Reject audio files that contain less than this fraction of speech.<br/>
        /// Valid values are in the range [0, 1] inclusive.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="summarization">
        /// Enable [Summarization](https://www.assemblyai.com/docs/models/summarization), can be true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="summaryModel">
        /// The model to summarize the transcript
        /// </param>
        /// <param name="summaryType">
        /// The type of summary
        /// </param>
        /// <param name="customTopics">
        /// Enable custom topics, either true or false<br/>
        /// Default Value: false
        /// </param>
        /// <param name="topics">
        /// The list of custom topics
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptOptionalParams(
            global::G.OneOf<global::G.AnyOf<global::G.TranscriptLanguageCode?, string>?, object>? languageCode,
            bool? languageDetection,
            float? languageConfidenceThreshold,
            global::G.OneOf<global::G.SpeechModel2?, object>? speechModel,
            bool? punctuate,
            bool? formatText,
            bool? disfluencies,
            bool? dualChannel,
            string? webhookUrl,
            object? webhookAuthHeaderName,
            object? webhookAuthHeaderValue,
            bool? autoHighlights,
            int? audioStartFrom,
            int? audioEndAt,
            global::System.Collections.Generic.IList<string>? wordBoost,
            global::G.TranscriptBoostParam? boostParam,
            bool? filterProfanity,
            bool? redactPii,
            bool? redactPiiAudio,
            global::G.RedactPiiAudioQuality? redactPiiAudioQuality,
            global::System.Collections.Generic.IList<global::G.PiiPolicy>? redactPiiPolicies,
            global::G.OneOf<global::G.SubstitutionPolicy?, object>? redactPiiSub,
            bool? speakerLabels,
            object? speakersExpected,
            bool? contentSafety,
            int? contentSafetyConfidence,
            bool? iabCategories,
            global::System.Collections.Generic.IList<global::G.TranscriptCustomSpelling>? customSpelling,
            bool? sentimentAnalysis,
            bool? autoChapters,
            bool? entityDetection,
            float? speechThreshold,
            bool? summarization,
            global::G.SummaryModel? summaryModel,
            global::G.SummaryType? summaryType,
            bool? customTopics,
            global::System.Collections.Generic.IList<string>? topics)
        {
            this.LanguageCode = languageCode;
            this.LanguageDetection = languageDetection;
            this.LanguageConfidenceThreshold = languageConfidenceThreshold;
            this.SpeechModel = speechModel;
            this.Punctuate = punctuate;
            this.FormatText = formatText;
            this.Disfluencies = disfluencies;
            this.DualChannel = dualChannel;
            this.WebhookUrl = webhookUrl;
            this.WebhookAuthHeaderName = webhookAuthHeaderName;
            this.WebhookAuthHeaderValue = webhookAuthHeaderValue;
            this.AutoHighlights = autoHighlights;
            this.AudioStartFrom = audioStartFrom;
            this.AudioEndAt = audioEndAt;
            this.WordBoost = wordBoost;
            this.BoostParam = boostParam;
            this.FilterProfanity = filterProfanity;
            this.RedactPii = redactPii;
            this.RedactPiiAudio = redactPiiAudio;
            this.RedactPiiAudioQuality = redactPiiAudioQuality;
            this.RedactPiiPolicies = redactPiiPolicies;
            this.RedactPiiSub = redactPiiSub;
            this.SpeakerLabels = speakerLabels;
            this.SpeakersExpected = speakersExpected;
            this.ContentSafety = contentSafety;
            this.ContentSafetyConfidence = contentSafetyConfidence;
            this.IabCategories = iabCategories;
            this.CustomSpelling = customSpelling;
            this.SentimentAnalysis = sentimentAnalysis;
            this.AutoChapters = autoChapters;
            this.EntityDetection = entityDetection;
            this.SpeechThreshold = speechThreshold;
            this.Summarization = summarization;
            this.SummaryModel = summaryModel;
            this.SummaryType = summaryType;
            this.CustomTopics = customTopics;
            this.Topics = topics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptOptionalParams" /> class.
        /// </summary>
        public TranscriptOptionalParams()
        {
        }
    }
}