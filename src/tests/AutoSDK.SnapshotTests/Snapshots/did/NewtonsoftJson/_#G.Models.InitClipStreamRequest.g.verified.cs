//HintName: G.Models.InitClipStreamRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitClipStreamRequest
    {
        /// <summary>
        /// ID of the selected presenter.<br/>
        /// Example: rian-lZC6MmWfC1
        /// </summary>
        /// <example>rian-lZC6MmWfC1</example>
        [global::Newtonsoft.Json.JsonProperty("presenter_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PresenterId { get; set; } = default!;

        /// <summary>
        /// Defines the video codec to be used in the stream.<br/>
        /// When set to on: VP8 will be used.<br/>
        /// When set to off: H264 will be used<br/>
        /// When set to auto the codec will be selected according to the browser.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compatibility_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InitClipStreamRequestCompatibilityModeJsonConverter))]
        public global::G.InitClipStreamRequestCompatibilityMode? CompatibilityMode { get; set; }

        /// <summary>
        /// Whether to stream wamrup video on the connection.<br/>
        /// If set to true, will stream a warmup video when connection is established.<br/>
        /// At the end of the warmup video, a message containing "stream/ready" will be sent on the data channel.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_warmup")]
        public bool? StreamWarmup { get; set; }

        /// <summary>
        /// Maximum duration (in seconds) between messages before session times out.<br/>
        /// Can only be used with proper permissions<br/>
        /// Example: 180
        /// </summary>
        /// <example>180</example>
        [global::Newtonsoft.Json.JsonProperty("session_timeout")]
        public double? SessionTimeout { get; set; }

        /// <summary>
        /// The output resolution sets the maximum height or width of the streamed video.<br/>
        /// The aspect ratio is preserved from the source video.<br/>
        /// When resolution is not configured, it defaults to the agent output resolution.<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::Newtonsoft.Json.JsonProperty("output_resolution")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? OutputResolution { get; set; }

        /// <summary>
        /// Whether to request a fluent stream.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fluent")]
        public bool? Fluent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitClipStreamRequest" /> class.
        /// </summary>
        /// <param name="presenterId">
        /// ID of the selected presenter.<br/>
        /// Example: rian-lZC6MmWfC1
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
        /// <param name="fluent">
        /// Whether to request a fluent stream.<br/>
        /// Default Value: false
        /// </param>
        public InitClipStreamRequest(
            string presenterId,
            global::G.InitClipStreamRequestCompatibilityMode? compatibilityMode,
            bool? streamWarmup,
            double? sessionTimeout,
            bool? fluent)
        {
            this.PresenterId = presenterId ?? throw new global::System.ArgumentNullException(nameof(presenterId));
            this.CompatibilityMode = compatibilityMode;
            this.StreamWarmup = streamWarmup;
            this.SessionTimeout = sessionTimeout;
            this.Fluent = fluent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitClipStreamRequest" /> class.
        /// </summary>
        public InitClipStreamRequest()
        {
        }
    }
}