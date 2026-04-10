//HintName: G.ITalksStreamsClient.CreateStream.g.cs
#nullable enable

namespace G
{
    public partial interface ITalksStreamsClient
    {
        /// <summary>
        /// Create a new stream<br/>
        /// Initiates the creation of a new WebRTC connection to a browser peer. The endpoint returns the necessary information to set up and manage the connection.
        /// </summary>
        /// <param name="userAgent"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.CreateStreamResponse3> CreateStreamAsync(

            global::G.CreateStreamRequest2 request,
            string? userAgent = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new stream<br/>
        /// Initiates the creation of a new WebRTC connection to a browser peer. The endpoint returns the necessary information to set up and manage the connection.
        /// </summary>
        /// <param name="userAgent"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.CreateStreamResponse3> CreateStreamAsync(
            string sourceUrl,
            string? userAgent = default,
            global::G.CreateStreamRequestFace? face = default,
            global::G.CreateStreamRequestConfig? config = default,
            global::G.CreateStreamRequestCompatibilityMode2? compatibilityMode = default,
            bool? streamWarmup = default,
            double? sessionTimeout = default,
            double? outputResolution = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}