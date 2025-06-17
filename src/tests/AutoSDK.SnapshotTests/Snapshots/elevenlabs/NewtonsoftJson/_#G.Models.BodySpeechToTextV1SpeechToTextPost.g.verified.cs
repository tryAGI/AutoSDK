//HintName: G.Models.BodySpeechToTextV1SpeechToTextPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodySpeechToTextV1SpeechToTextPost
    {
        /// <summary>
        /// The ID of the model to use for transcription, currently only 'scribe_v1' and 'scribe_v1_experimental' are available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// The file to transcribe. All major audio and video formats are supported. Exactly one of the file or cloud_storage_url parameters must be provided. The file size must be less than 1GB.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// The file to transcribe. All major audio and video formats are supported. Exactly one of the file or cloud_storage_url parameters must be provided. The file size must be less than 1GB.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// An ISO-639-1 or ISO-639-3 language_code corresponding to the language of the audio file. Can sometimes improve transcription performance if known beforehand. Defaults to null, in this case the language is predicted automatically.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Whether to tag audio events like (laughter), (footsteps), etc. in the transcription.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag_audio_events")]
        public bool? TagAudioEvents { get; set; }

        /// <summary>
        /// The maximum amount of speakers talking in the uploaded file. Can help with predicting who speaks when. The maximum amount of speakers that can be predicted is 32. Defaults to null, in this case the amount of speakers is set to the maximum value the model supports.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_speakers")]
        public int? NumSpeakers { get; set; }

        /// <summary>
        /// The granularity of the timestamps in the transcription. 'word' provides word-level timestamps and 'character' provides character-level timestamps per word.<br/>
        /// Default Value: word
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamps_granularity")]
        public global::G.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? TimestampsGranularity { get; set; }

        /// <summary>
        /// Whether to annotate which speaker is currently talking in the uploaded file.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diarize")]
        public bool? Diarize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional_formats")]
        public global::System.Collections.Generic.IList<global::G.ExportOptions>? AdditionalFormats { get; set; }

        /// <summary>
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other<br/>
        /// Example: pcm_s16le_16
        /// </summary>
        /// <example>pcm_s16le_16</example>
        [global::Newtonsoft.Json.JsonProperty("file_format")]
        public global::G.BodySpeechToTextV1SpeechToTextPostFileFormat? FileFormat { get; set; }

        /// <summary>
        /// The valid AWS S3, Cloudflare R2 or Google Cloud Storage URL of the file to transcribe. Exactly one of the file or cloud_storage_url parameters must be provided. The file must be a valid publicly accessible cloud storage URL. The file size must be less than 2GB. URL can be pre-signed.<br/>
        /// Example: https://storage.googleapis.com/my-bucket/folder/audio.mp3
        /// </summary>
        /// <example>https://storage.googleapis.com/my-bucket/folder/audio.mp3</example>
        [global::Newtonsoft.Json.JsonProperty("cloud_storage_url")]
        public string? CloudStorageUrl { get; set; }

        /// <summary>
        /// Whether to send the transcription result to configured speech-to-text webhooks.  If set the request will return early without the transcription, which will be delivered later via webhook.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public bool? Webhook { get; set; }

        /// <summary>
        /// Controls the randomness of the transcription output. Accepts values between 0.0 and 2.0, where higher values result in more diverse and less deterministic results. If omitted, we will use a temperature based on the model you selected which is usually 0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySpeechToTextV1SpeechToTextPost" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model to use for transcription, currently only 'scribe_v1' and 'scribe_v1_experimental' are available.
        /// </param>
        /// <param name="file">
        /// The file to transcribe. All major audio and video formats are supported. Exactly one of the file or cloud_storage_url parameters must be provided. The file size must be less than 1GB.
        /// </param>
        /// <param name="filename">
        /// The file to transcribe. All major audio and video formats are supported. Exactly one of the file or cloud_storage_url parameters must be provided. The file size must be less than 1GB.
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
        /// <param name="additionalFormats"></param>
        /// <param name="fileFormat">
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other<br/>
        /// Example: pcm_s16le_16
        /// </param>
        /// <param name="cloudStorageUrl">
        /// The valid AWS S3, Cloudflare R2 or Google Cloud Storage URL of the file to transcribe. Exactly one of the file or cloud_storage_url parameters must be provided. The file must be a valid publicly accessible cloud storage URL. The file size must be less than 2GB. URL can be pre-signed.<br/>
        /// Example: https://storage.googleapis.com/my-bucket/folder/audio.mp3
        /// </param>
        /// <param name="webhook">
        /// Whether to send the transcription result to configured speech-to-text webhooks.  If set the request will return early without the transcription, which will be delivered later via webhook.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the transcription output. Accepts values between 0.0 and 2.0, where higher values result in more diverse and less deterministic results. If omitted, we will use a temperature based on the model you selected which is usually 0.
        /// </param>
        public BodySpeechToTextV1SpeechToTextPost(
            string modelId,
            byte[]? file,
            string? filename,
            string? languageCode,
            bool? tagAudioEvents,
            int? numSpeakers,
            global::G.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? timestampsGranularity,
            bool? diarize,
            global::System.Collections.Generic.IList<global::G.ExportOptions>? additionalFormats,
            global::G.BodySpeechToTextV1SpeechToTextPostFileFormat? fileFormat,
            string? cloudStorageUrl,
            bool? webhook,
            double? temperature)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.File = file;
            this.Filename = filename;
            this.LanguageCode = languageCode;
            this.TagAudioEvents = tagAudioEvents;
            this.NumSpeakers = numSpeakers;
            this.TimestampsGranularity = timestampsGranularity;
            this.Diarize = diarize;
            this.AdditionalFormats = additionalFormats;
            this.FileFormat = fileFormat;
            this.CloudStorageUrl = cloudStorageUrl;
            this.Webhook = webhook;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySpeechToTextV1SpeechToTextPost" /> class.
        /// </summary>
        public BodySpeechToTextV1SpeechToTextPost()
        {
        }
    }
}