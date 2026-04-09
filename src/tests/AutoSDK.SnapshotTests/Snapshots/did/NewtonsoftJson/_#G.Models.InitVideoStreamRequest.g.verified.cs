//HintName: G.Models.InitVideoStreamRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InitVideoStreamRequest
    {
        /// <summary>
        /// Whether to request a fluent stream.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fluent")]
        public bool? Fluent { get; set; }

        /// <summary>
        /// Maximum duration (in seconds) between messages before session times out.<br/>
        /// Can only be used with proper permissions<br/>
        /// Example: 180
        /// </summary>
        /// <example>180</example>
        [global::Newtonsoft.Json.JsonProperty("session_timeout")]
        public double? SessionTimeout { get; set; }

        /// <summary>
        /// Whether to stream wamrup video on the connection.<br/>
        /// If set to true, will stream a warmup video when connection is established.<br/>
        /// At the end of the warmup video, a message containing "stream/ready" will be sent on the data channel.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_warmup")]
        public bool? StreamWarmup { get; set; }

        /// <summary>
        /// Defines the video codec to be used in the stream.<br/>
        /// When set to on: VP8 will be used.<br/>
        /// When set to off: H264 will be used<br/>
        /// When set to auto the codec will be selected according to the browser.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compatibility_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InitVideoStreamRequestCompatibilityModeJsonConverter))]
        public global::G.InitVideoStreamRequestCompatibilityMode? CompatibilityMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitVideoStreamRequest" /> class.
        /// </summary>
        /// <param name="fluent">
        /// Whether to request a fluent stream.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sessionTimeout">
        /// Maximum duration (in seconds) between messages before session times out.<br/>
        /// Can only be used with proper permissions<br/>
        /// Example: 180
        /// </param>
        /// <param name="streamWarmup">
        /// Whether to stream wamrup video on the connection.<br/>
        /// If set to true, will stream a warmup video when connection is established.<br/>
        /// At the end of the warmup video, a message containing "stream/ready" will be sent on the data channel.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="compatibilityMode">
        /// Defines the video codec to be used in the stream.<br/>
        /// When set to on: VP8 will be used.<br/>
        /// When set to off: H264 will be used<br/>
        /// When set to auto the codec will be selected according to the browser.
        /// </param>
        public InitVideoStreamRequest(
            bool? fluent,
            double? sessionTimeout,
            bool? streamWarmup,
            global::G.InitVideoStreamRequestCompatibilityMode? compatibilityMode)
        {
            this.Fluent = fluent;
            this.SessionTimeout = sessionTimeout;
            this.StreamWarmup = streamWarmup;
            this.CompatibilityMode = compatibilityMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitVideoStreamRequest" /> class.
        /// </summary>
        public InitVideoStreamRequest()
        {
        }
    }
}