//HintName: G.IApi.InitialiseWebrtcWorkerInitialiseWebrtcWorkerPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// [EXPERIMENTAL] Establishes WebRTC peer connection and processes video stream in spawned process or modal function<br/>
        /// [EXPERIMENTAL] Establishes WebRTC peer connection and processes video stream in spawned process or modal function
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InitializeWebRTCResponse> InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsync(

            global::G.WebRTCWorkerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [EXPERIMENTAL] Establishes WebRTC peer connection and processes video stream in spawned process or modal function<br/>
        /// [EXPERIMENTAL] Establishes WebRTC peer connection and processes video stream in spawned process or modal function
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="workflowConfiguration"></param>
        /// <param name="isPreview">
        /// Default Value: false
        /// </param>
        /// <param name="webrtcOffer"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.InitializeWebRTCResponse> InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsync(
            global::G.WorkflowConfiguration workflowConfiguration,
            global::G.WebRTCOffer webrtcOffer,
            string? apiKey = default,
            bool? isPreview = default,
            global::G.WebRTCConfig? webrtcConfig = default,
            global::G.WebRTCTURNConfig? webrtcTurnConfig = default,
            bool? webrtcRealtimeProcessing = default,
            global::System.Collections.Generic.IList<string>? streamOutput = default,
            global::System.Collections.Generic.IList<string>? dataOutput = default,
            double? declaredFps = default,
            string? rtspUrl = default,
            string? mjpegUrl = default,
            int? processingTimeout = default,
            global::System.DateTime? processingSessionStarted = default,
            string? requestedPlan = default,
            string? requestedGpu = default,
            string? requestedRegion = default,
            string? workspaceId = default,
            string? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}