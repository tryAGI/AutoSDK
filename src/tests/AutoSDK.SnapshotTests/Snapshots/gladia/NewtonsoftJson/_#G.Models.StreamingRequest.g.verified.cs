//HintName: G.Models.StreamingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingRequest
    {
        /// <summary>
        /// The encoding format of the audio stream. Supported formats: <br/>
        /// - PCM: 8, 16, 24, and 32 bits <br/>
        /// - A-law: 8 bits <br/>
        /// - μ-law: 8 bits <br/>
        /// Note: No need to add WAV headers to raw audio as the API supports both formats.<br/>
        /// Default Value: wav/pcm
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoding")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StreamingSupportedEncodingEnumJsonConverter))]
        public global::G.StreamingSupportedEncodingEnum? Encoding { get; set; }

        /// <summary>
        /// The bit depth of the audio stream<br/>
        /// Default Value: 16
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bit_depth")]
        public double? BitDepth { get; set; }

        /// <summary>
        /// The sample rate of the audio stream<br/>
        /// Default Value: 16000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_rate")]
        public double? SampleRate { get; set; }

        /// <summary>
        /// The number of channels of the audio stream<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channels")]
        public int? Channels { get; set; }

        /// <summary>
        /// Custom metadata you can attach to this live transcription<br/>
        /// Example: {"user":"John Doe"}
        /// </summary>
        /// <example>{"user":"John Doe"}</example>
        [global::Newtonsoft.Json.JsonProperty("custom_metadata")]
        public object? CustomMetadata { get; set; }

        /// <summary>
        /// The model used to process the audio. "solaria-1" is used by default.<br/>
        /// Default Value: solaria-1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StreamingSupportedModelsJsonConverter))]
        public global::G.StreamingSupportedModels? Model { get; set; }

        /// <summary>
        /// The endpointing duration in seconds. Endpointing is the duration of silence which will cause an utterance to be considered as finished<br/>
        /// Default Value: 0.05F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpointing")]
        public double? Endpointing { get; set; }

        /// <summary>
        /// The maximum duration in seconds without endpointing. If endpointing is not detected after this duration, current utterance will be considered as finished<br/>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maximum_duration_without_endpointing")]
        public double? MaximumDurationWithoutEndpointing { get; set; }

        /// <summary>
        /// Specify the language configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_config")]
        public global::G.LanguageConfig? LanguageConfig { get; set; }

        /// <summary>
        /// Specify the pre-processing configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pre_processing")]
        public global::G.PreProcessingConfig? PreProcessing { get; set; }

        /// <summary>
        /// Specify the realtime processing configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("realtime_processing")]
        public global::G.RealtimeProcessingConfig? RealtimeProcessing { get; set; }

        /// <summary>
        /// Specify the post-processing configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("post_processing")]
        public global::G.PostProcessingConfig? PostProcessing { get; set; }

        /// <summary>
        /// Specify the websocket messages configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages_config")]
        public global::G.MessagesConfig? MessagesConfig { get; set; }

        /// <summary>
        /// If true, messages will be sent to configured url.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback")]
        public bool? Callback { get; set; }

        /// <summary>
        /// Specify the callback configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_config")]
        public global::G.CallbackConfig? CallbackConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingRequest" /> class.
        /// </summary>
        /// <param name="encoding">
        /// The encoding format of the audio stream. Supported formats: <br/>
        /// - PCM: 8, 16, 24, and 32 bits <br/>
        /// - A-law: 8 bits <br/>
        /// - μ-law: 8 bits <br/>
        /// Note: No need to add WAV headers to raw audio as the API supports both formats.<br/>
        /// Default Value: wav/pcm
        /// </param>
        /// <param name="bitDepth">
        /// The bit depth of the audio stream<br/>
        /// Default Value: 16
        /// </param>
        /// <param name="sampleRate">
        /// The sample rate of the audio stream<br/>
        /// Default Value: 16000
        /// </param>
        /// <param name="channels">
        /// The number of channels of the audio stream<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata you can attach to this live transcription<br/>
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="model">
        /// The model used to process the audio. "solaria-1" is used by default.<br/>
        /// Default Value: solaria-1
        /// </param>
        /// <param name="endpointing">
        /// The endpointing duration in seconds. Endpointing is the duration of silence which will cause an utterance to be considered as finished<br/>
        /// Default Value: 0.05F
        /// </param>
        /// <param name="maximumDurationWithoutEndpointing">
        /// The maximum duration in seconds without endpointing. If endpointing is not detected after this duration, current utterance will be considered as finished<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="languageConfig">
        /// Specify the language configuration
        /// </param>
        /// <param name="preProcessing">
        /// Specify the pre-processing configuration
        /// </param>
        /// <param name="realtimeProcessing">
        /// Specify the realtime processing configuration
        /// </param>
        /// <param name="postProcessing">
        /// Specify the post-processing configuration
        /// </param>
        /// <param name="messagesConfig">
        /// Specify the websocket messages configuration
        /// </param>
        /// <param name="callback">
        /// If true, messages will be sent to configured url.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="callbackConfig">
        /// Specify the callback configuration
        /// </param>
        public StreamingRequest(
            global::G.StreamingSupportedEncodingEnum? encoding,
            double? bitDepth,
            double? sampleRate,
            int? channels,
            object? customMetadata,
            global::G.StreamingSupportedModels? model,
            double? endpointing,
            double? maximumDurationWithoutEndpointing,
            global::G.LanguageConfig? languageConfig,
            global::G.PreProcessingConfig? preProcessing,
            global::G.RealtimeProcessingConfig? realtimeProcessing,
            global::G.PostProcessingConfig? postProcessing,
            global::G.MessagesConfig? messagesConfig,
            bool? callback,
            global::G.CallbackConfig? callbackConfig)
        {
            this.Encoding = encoding;
            this.BitDepth = bitDepth;
            this.SampleRate = sampleRate;
            this.Channels = channels;
            this.CustomMetadata = customMetadata;
            this.Model = model;
            this.Endpointing = endpointing;
            this.MaximumDurationWithoutEndpointing = maximumDurationWithoutEndpointing;
            this.LanguageConfig = languageConfig;
            this.PreProcessing = preProcessing;
            this.RealtimeProcessing = realtimeProcessing;
            this.PostProcessing = postProcessing;
            this.MessagesConfig = messagesConfig;
            this.Callback = callback;
            this.CallbackConfig = callbackConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingRequest" /> class.
        /// </summary>
        public StreamingRequest()
        {
        }
    }
}