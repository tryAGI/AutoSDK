//HintName: G.Models.InitTalkStreamRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitTalkStreamRequest
    {
        /// <summary>
        /// URL to a photo you wish to animate in the stream
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceUrl { get; set; }

        /// <summary>
        /// the face to animate - otherwise detects the dominant face
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face")]
        public global::G.InitTalkStreamRequestFace? Face { get; set; }

        /// <summary>
        /// Advanced configuration options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.InitTalkStreamRequestConfig? Config { get; set; }

        /// <summary>
        /// Defines the video codec to be used in the stream.<br/>
        /// When set to on: VP8 will be used.<br/>
        /// When set to off: H264 will be used<br/>
        /// When set to auto the codec will be selected according to the browser.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compatibility_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InitTalkStreamRequestCompatibilityModeJsonConverter))]
        public global::G.InitTalkStreamRequestCompatibilityMode? CompatibilityMode { get; set; }

        /// <summary>
        /// Whether to stream wamrup video on the connection.<br/>
        /// If set to true, will stream a warmup video when connection is established.<br/>
        /// At the end of the warmup video, a message containing "stream/ready" will be sent on the data channel.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_warmup")]
        public bool? StreamWarmup { get; set; }

        /// <summary>
        /// Maximum duration (in seconds) between messages before session times out.<br/>
        /// Can only be used with proper permissions<br/>
        /// Example: 180
        /// </summary>
        /// <example>180</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_timeout")]
        public double? SessionTimeout { get; set; }

        /// <summary>
        /// The output resolution sets the maximum height or width of the streamed video.<br/>
        /// The aspect ratio is preserved from the source image.<br/>
        /// When resolution is not configured, it defaults to the agent output resolution.<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_resolution")]
        public double? OutputResolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitTalkStreamRequest" /> class.
        /// </summary>
        /// <param name="sourceUrl">
        /// URL to a photo you wish to animate in the stream
        /// </param>
        /// <param name="face">
        /// the face to animate - otherwise detects the dominant face
        /// </param>
        /// <param name="config">
        /// Advanced configuration options.
        /// </param>
        /// <param name="compatibilityMode">
        /// Defines the video codec to be used in the stream.<br/>
        /// When set to on: VP8 will be used.<br/>
        /// When set to off: H264 will be used<br/>
        /// When set to auto the codec will be selected according to the browser.
        /// </param>
        /// <param name="streamWarmup">
        /// Whether to stream wamrup video on the connection.<br/>
        /// If set to true, will stream a warmup video when connection is established.<br/>
        /// At the end of the warmup video, a message containing "stream/ready" will be sent on the data channel.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sessionTimeout">
        /// Maximum duration (in seconds) between messages before session times out.<br/>
        /// Can only be used with proper permissions<br/>
        /// Example: 180
        /// </param>
        /// <param name="outputResolution">
        /// The output resolution sets the maximum height or width of the streamed video.<br/>
        /// The aspect ratio is preserved from the source image.<br/>
        /// When resolution is not configured, it defaults to the agent output resolution.<br/>
        /// Example: 512
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InitTalkStreamRequest(
            string sourceUrl,
            global::G.InitTalkStreamRequestFace? face,
            global::G.InitTalkStreamRequestConfig? config,
            global::G.InitTalkStreamRequestCompatibilityMode? compatibilityMode,
            bool? streamWarmup,
            double? sessionTimeout,
            double? outputResolution)
        {
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
            this.Face = face;
            this.Config = config;
            this.CompatibilityMode = compatibilityMode;
            this.StreamWarmup = streamWarmup;
            this.SessionTimeout = sessionTimeout;
            this.OutputResolution = outputResolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitTalkStreamRequest" /> class.
        /// </summary>
        public InitTalkStreamRequest()
        {
        }
    }
}