//HintName: G.Models.BodySpeechToTextV1SpeechToTextPost.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodySpeechToTextV1SpeechToTextPost
    {
        /// <summary>
        /// The ID of the model to use for transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostModelIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BodySpeechToTextV1SpeechToTextPostModelId ModelId { get; set; }

        /// <summary>
        /// The file to transcribe. All major audio and video formats are supported. Exactly one of the file or cloud_storage_url parameters must be provided. The file size must be less than 3.0GB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// An ISO-639-1 or ISO-639-3 language_code corresponding to the language of the audio file. Can sometimes improve transcription performance if known beforehand. Defaults to null, in this case the language is predicted automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Whether to tag audio events like (laughter), (footsteps), etc. in the transcription.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_audio_events")]
        public bool? TagAudioEvents { get; set; }

        /// <summary>
        /// The maximum amount of speakers talking in the uploaded file. Can help with predicting who speaks when. The maximum amount of speakers that can be predicted is 32. Defaults to null, in this case the amount of speakers is set to the maximum value the model supports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_speakers")]
        public int? NumSpeakers { get; set; }

        /// <summary>
        /// The granularity of the timestamps in the transcription. 'word' provides word-level timestamps and 'character' provides character-level timestamps per word.<br/>
        /// Default Value: word
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamps_granularity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostTimestampsGranularityJsonConverter))]
        public global::G.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? TimestampsGranularity { get; set; }

        /// <summary>
        /// Whether to annotate which speaker is currently talking in the uploaded file.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarize")]
        public bool? Diarize { get; set; }

        /// <summary>
        /// Diarization threshold to apply during speaker diarization. A higher value means there will be a lower chance of one speaker being diarized as two different speakers but also a higher chance of two different speakers being diarized as one speaker (less total speakers predicted). A low value means there will be a higher chance of one speaker being diarized as two different speakers but also a lower chance of two different speakers being diarized as one speaker (more total speakers predicted). Can only be set when diarize=True and num_speakers=None. Defaults to None, in which case we will choose a threshold based on the model_id (0.22 usually).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarization_threshold")]
        public double? DiarizationThreshold { get; set; }

        /// <summary>
        /// A list of additional formats to export the transcript to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_formats")]
        public global::System.Collections.Generic.IList<global::G.ExportOptions>? AdditionalFormats { get; set; }

        /// <summary>
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodySpeechToTextV1SpeechToTextPostFileFormatJsonConverter))]
        public global::G.BodySpeechToTextV1SpeechToTextPostFileFormat? FileFormat { get; set; }

        /// <summary>
        /// The HTTPS URL of the file to transcribe. Exactly one of the file or cloud_storage_url parameters must be provided. The file must be accessible via HTTPS and the file size must be less than 2GB. Any valid HTTPS URL is accepted, including URLs from cloud storage providers (AWS S3, Google Cloud Storage, Cloudflare R2, etc.), CDNs, or any other HTTPS source. URLs can be pre-signed or include authentication tokens in query parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud_storage_url")]
        public string? CloudStorageUrl { get; set; }

        /// <summary>
        /// Whether to send the transcription result to configured speech-to-text webhooks.  If set the request will return early without the transcription, which will be delivered later via webhook.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public bool? Webhook { get; set; }

        /// <summary>
        /// Optional specific webhook ID to send the transcription result to. Only valid when webhook is set to true. If not provided, transcription will be sent to all configured speech-to-text webhooks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_id")]
        public string? WebhookId { get; set; }

        /// <summary>
        /// Controls the randomness of the transcription output. Accepts values between 0.0 and 2.0, where higher values result in more diverse and less deterministic results. If omitted, we will use a temperature based on the model you selected which is usually 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be an integer between 0 and 2147483647.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Whether the audio file contains multiple channels where each channel contains a single speaker. When enabled, each channel will be transcribed independently and the results will be combined. Each word in the response will include a 'channel_index' field indicating which channel it was spoken on. A maximum of 5 channels is supported.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_multi_channel")]
        public bool? UseMultiChannel { get; set; }

        /// <summary>
        /// Optional metadata to be included in the webhook response. This should be a JSON string representing an object with a maximum depth of 2 levels and maximum size of 16KB. Useful for tracking internal IDs, job references, or other contextual information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, object, object>))]
        public global::G.AnyOf<string, object, object>? WebhookMetadata { get; set; }

        /// <summary>
        /// Detect entities in the transcript. Can be 'all' to detect all entities, a single entity type or category string, or a list of entity types/categories. Categories include 'pii', 'phi', 'pci', 'other', 'offensive_language'. When enabled, detected entities will be returned in the 'entities' field with their text, type, and character positions. Usage of this parameter will incur additional costs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_detection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>))]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? EntityDetection { get; set; }

        /// <summary>
        /// If true, the transcription will not have any filler words, false starts and non-speech sounds. Only supported with scribe_v2 model.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_verbatim")]
        public bool? NoVerbatim { get; set; }

        /// <summary>
        /// A list of keyterms to bias the transcription towards.           The keyterms are words or phrases you want the model to recognise more accurately.           The number of keyterms cannot exceed 100.           The length of each keyterm must be less than 50 characters.           Keyterms can contain at most 5 words (after normalisation).           For example ["hello", "world", "technical term"].           Usage of this parameter will incur additional costs.  <br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySpeechToTextV1SpeechToTextPost" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model to use for transcription.
        /// </param>
        /// <param name="file">
        /// The file to transcribe. All major audio and video formats are supported. Exactly one of the file or cloud_storage_url parameters must be provided. The file size must be less than 3.0GB.
        /// </param>
        /// <param name="languageCode">
        /// An ISO-639-1 or ISO-639-3 language_code corresponding to the language of the audio file. Can sometimes improve transcription performance if known beforehand. Defaults to null, in this case the language is predicted automatically.
        /// </param>
        /// <param name="tagAudioEvents">
        /// Whether to tag audio events like (laughter), (footsteps), etc. in the transcription.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="numSpeakers">
        /// The maximum amount of speakers talking in the uploaded file. Can help with predicting who speaks when. The maximum amount of speakers that can be predicted is 32. Defaults to null, in this case the amount of speakers is set to the maximum value the model supports.
        /// </param>
        /// <param name="timestampsGranularity">
        /// The granularity of the timestamps in the transcription. 'word' provides word-level timestamps and 'character' provides character-level timestamps per word.<br/>
        /// Default Value: word
        /// </param>
        /// <param name="diarize">
        /// Whether to annotate which speaker is currently talking in the uploaded file.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="diarizationThreshold">
        /// Diarization threshold to apply during speaker diarization. A higher value means there will be a lower chance of one speaker being diarized as two different speakers but also a higher chance of two different speakers being diarized as one speaker (less total speakers predicted). A low value means there will be a higher chance of one speaker being diarized as two different speakers but also a lower chance of two different speakers being diarized as one speaker (more total speakers predicted). Can only be set when diarize=True and num_speakers=None. Defaults to None, in which case we will choose a threshold based on the model_id (0.22 usually).
        /// </param>
        /// <param name="additionalFormats">
        /// A list of additional formats to export the transcript to.
        /// </param>
        /// <param name="fileFormat">
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other
        /// </param>
        /// <param name="cloudStorageUrl">
        /// The HTTPS URL of the file to transcribe. Exactly one of the file or cloud_storage_url parameters must be provided. The file must be accessible via HTTPS and the file size must be less than 2GB. Any valid HTTPS URL is accepted, including URLs from cloud storage providers (AWS S3, Google Cloud Storage, Cloudflare R2, etc.), CDNs, or any other HTTPS source. URLs can be pre-signed or include authentication tokens in query parameters.
        /// </param>
        /// <param name="webhook">
        /// Whether to send the transcription result to configured speech-to-text webhooks.  If set the request will return early without the transcription, which will be delivered later via webhook.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookId">
        /// Optional specific webhook ID to send the transcription result to. Only valid when webhook is set to true. If not provided, transcription will be sent to all configured speech-to-text webhooks.
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the transcription output. Accepts values between 0.0 and 2.0, where higher values result in more diverse and less deterministic results. If omitted, we will use a temperature based on the model you selected which is usually 0.
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be an integer between 0 and 2147483647.
        /// </param>
        /// <param name="useMultiChannel">
        /// Whether the audio file contains multiple channels where each channel contains a single speaker. When enabled, each channel will be transcribed independently and the results will be combined. Each word in the response will include a 'channel_index' field indicating which channel it was spoken on. A maximum of 5 channels is supported.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookMetadata">
        /// Optional metadata to be included in the webhook response. This should be a JSON string representing an object with a maximum depth of 2 levels and maximum size of 16KB. Useful for tracking internal IDs, job references, or other contextual information.
        /// </param>
        /// <param name="entityDetection">
        /// Detect entities in the transcript. Can be 'all' to detect all entities, a single entity type or category string, or a list of entity types/categories. Categories include 'pii', 'phi', 'pci', 'other', 'offensive_language'. When enabled, detected entities will be returned in the 'entities' field with their text, type, and character positions. Usage of this parameter will incur additional costs.
        /// </param>
        /// <param name="noVerbatim">
        /// If true, the transcription will not have any filler words, false starts and non-speech sounds. Only supported with scribe_v2 model.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="keyterms">
        /// A list of keyterms to bias the transcription towards.           The keyterms are words or phrases you want the model to recognise more accurately.           The number of keyterms cannot exceed 100.           The length of each keyterm must be less than 50 characters.           Keyterms can contain at most 5 words (after normalisation).           For example ["hello", "world", "technical term"].           Usage of this parameter will incur additional costs.  <br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySpeechToTextV1SpeechToTextPost(
            global::G.BodySpeechToTextV1SpeechToTextPostModelId modelId,
            byte[]? file,
            string? languageCode,
            bool? tagAudioEvents,
            int? numSpeakers,
            global::G.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? timestampsGranularity,
            bool? diarize,
            double? diarizationThreshold,
            global::System.Collections.Generic.IList<global::G.ExportOptions>? additionalFormats,
            global::G.BodySpeechToTextV1SpeechToTextPostFileFormat? fileFormat,
            string? cloudStorageUrl,
            bool? webhook,
            string? webhookId,
            double? temperature,
            int? seed,
            bool? useMultiChannel,
            global::G.AnyOf<string, object, object>? webhookMetadata,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? entityDetection,
            bool? noVerbatim,
            global::System.Collections.Generic.IList<string>? keyterms)
        {
            this.ModelId = modelId;
            this.File = file;
            this.LanguageCode = languageCode;
            this.TagAudioEvents = tagAudioEvents;
            this.NumSpeakers = numSpeakers;
            this.TimestampsGranularity = timestampsGranularity;
            this.Diarize = diarize;
            this.DiarizationThreshold = diarizationThreshold;
            this.AdditionalFormats = additionalFormats;
            this.FileFormat = fileFormat;
            this.CloudStorageUrl = cloudStorageUrl;
            this.Webhook = webhook;
            this.WebhookId = webhookId;
            this.Temperature = temperature;
            this.Seed = seed;
            this.UseMultiChannel = useMultiChannel;
            this.WebhookMetadata = webhookMetadata;
            this.EntityDetection = entityDetection;
            this.NoVerbatim = noVerbatim;
            this.Keyterms = keyterms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySpeechToTextV1SpeechToTextPost" /> class.
        /// </summary>
        public BodySpeechToTextV1SpeechToTextPost()
        {
        }
    }
}