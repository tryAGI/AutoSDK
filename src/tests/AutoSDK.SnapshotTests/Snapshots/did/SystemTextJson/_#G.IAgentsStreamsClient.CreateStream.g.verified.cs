//HintName: G.IAgentsStreamsClient.CreateStream.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsStreamsClient
    {
        /// <summary>
        /// Create a new stream<br/>
        /// Initiates the creation of a new WebRTC connection to a browser peer. The endpoint returns the necessary information to set up and manage the connection.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateStreamResponse> CreateStreamAsync(
            string agentId,

            global::G.CreateStreamRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new stream<br/>
        /// Initiates the creation of a new WebRTC connection to a browser peer. The endpoint returns the necessary information to set up and manage the connection.
        /// </summary>
        /// <param name="agentId"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateStreamResponse> CreateStreamAsync(
            string agentId,
            bool? fluent = default,
            double? sessionTimeout = default,
            bool? streamWarmup = default,
            global::G.CreateStreamRequestCompatibilityMode? compatibilityMode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}