//HintName: G.Models.WebRTCWorkerRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebRTCWorkerRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_configuration", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WorkflowConfiguration WorkflowConfiguration { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_preview")]
        public bool? IsPreview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webrtc_offer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebRTCOffer WebrtcOffer { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webrtc_config")]
        public global::G.WebRTCConfig? WebrtcConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webrtc_turn_config")]
        public global::G.WebRTCTURNConfig? WebrtcTurnConfig { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webrtc_realtime_processing")]
        public bool? WebrtcRealtimeProcessing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_output")]
        public global::System.Collections.Generic.IList<string>? StreamOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_output")]
        public global::System.Collections.Generic.IList<string>? DataOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("declared_fps")]
        public double? DeclaredFps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rtsp_url")]
        public string? RtspUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mjpeg_url")]
        public string? MjpegUrl { get; set; }

        /// <summary>
        /// Default Value: 3600
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processing_timeout")]
        public int? ProcessingTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processing_session_started")]
        public global::System.DateTime? ProcessingSessionStarted { get; set; }

        /// <summary>
        /// Default Value: webrtc-gpu-small
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_plan")]
        public string? RequestedPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_gpu")]
        public string? RequestedGpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requested_region")]
        public string? RequestedRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRTCWorkerRequest" /> class.
        /// </summary>
        /// <param name="workflowConfiguration"></param>
        /// <param name="webrtcOffer"></param>
        /// <param name="apiKey"></param>
        /// <param name="isPreview">
        /// Default Value: false
        /// </param>
        /// <param name="webrtcConfig"></param>
        /// <param name="webrtcTurnConfig"></param>
        /// <param name="webrtcRealtimeProcessing">
        /// Default Value: true
        /// </param>
        /// <param name="streamOutput"></param>
        /// <param name="dataOutput"></param>
        /// <param name="declaredFps"></param>
        /// <param name="rtspUrl"></param>
        /// <param name="mjpegUrl"></param>
        /// <param name="processingTimeout">
        /// Default Value: 3600
        /// </param>
        /// <param name="processingSessionStarted"></param>
        /// <param name="requestedPlan">
        /// Default Value: webrtc-gpu-small
        /// </param>
        /// <param name="requestedGpu"></param>
        /// <param name="requestedRegion"></param>
        /// <param name="workspaceId"></param>
        /// <param name="sessionId"></param>
        public WebRTCWorkerRequest(
            global::G.WorkflowConfiguration workflowConfiguration,
            global::G.WebRTCOffer webrtcOffer,
            string? apiKey,
            bool? isPreview,
            global::G.WebRTCConfig? webrtcConfig,
            global::G.WebRTCTURNConfig? webrtcTurnConfig,
            bool? webrtcRealtimeProcessing,
            global::System.Collections.Generic.IList<string>? streamOutput,
            global::System.Collections.Generic.IList<string>? dataOutput,
            double? declaredFps,
            string? rtspUrl,
            string? mjpegUrl,
            int? processingTimeout,
            global::System.DateTime? processingSessionStarted,
            string? requestedPlan,
            string? requestedGpu,
            string? requestedRegion,
            string? workspaceId,
            string? sessionId)
        {
            this.ApiKey = apiKey;
            this.WorkflowConfiguration = workflowConfiguration ?? throw new global::System.ArgumentNullException(nameof(workflowConfiguration));
            this.IsPreview = isPreview;
            this.WebrtcOffer = webrtcOffer ?? throw new global::System.ArgumentNullException(nameof(webrtcOffer));
            this.WebrtcConfig = webrtcConfig;
            this.WebrtcTurnConfig = webrtcTurnConfig;
            this.WebrtcRealtimeProcessing = webrtcRealtimeProcessing;
            this.StreamOutput = streamOutput;
            this.DataOutput = dataOutput;
            this.DeclaredFps = declaredFps;
            this.RtspUrl = rtspUrl;
            this.MjpegUrl = mjpegUrl;
            this.ProcessingTimeout = processingTimeout;
            this.ProcessingSessionStarted = processingSessionStarted;
            this.RequestedPlan = requestedPlan;
            this.RequestedGpu = requestedGpu;
            this.RequestedRegion = requestedRegion;
            this.WorkspaceId = workspaceId;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRTCWorkerRequest" /> class.
        /// </summary>
        public WebRTCWorkerRequest()
        {
        }
    }
}