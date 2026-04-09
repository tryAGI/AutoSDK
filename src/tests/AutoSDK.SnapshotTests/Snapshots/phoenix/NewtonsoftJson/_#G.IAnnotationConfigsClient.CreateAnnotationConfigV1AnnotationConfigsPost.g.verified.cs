//HintName: G.IAnnotationConfigsClient.CreateAnnotationConfigV1AnnotationConfigsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationConfigsClient
    {
        /// <summary>
        /// Create an annotation configuration
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAnnotationConfigResponseBody> CreateAnnotationConfigV1AnnotationConfigsPostAsync(

            global::G.CreateAnnotationConfigData request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}