//HintName: G.IOpenAPIV1Client.CreateAsr.g.cs
#nullable enable

namespace G
{
    public partial interface IOpenAPIV1Client
    {
        /// <summary>
        /// Speech to Text
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAsrResponse> CreateAsrAsync(

            global::G.CreateAsrRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Speech to Text
        /// </summary>
        /// <param name="audio">
        /// Audio to be converted to text
        /// </param>
        /// <param name="audioname">
        /// Audio to be converted to text
        /// </param>
        /// <param name="language">
        /// Language to be used for the speech<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="ignoreTimestamps">
        /// Whether to return precise timestamps in the text, this will increase the latency in audio shorter than 30 seconds<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAsrResponse> CreateAsrAsync(
            byte[] audio,
            string audioname,
            string? language = default,
            bool? ignoreTimestamps = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}