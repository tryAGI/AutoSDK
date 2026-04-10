//HintName: G.IAnnotationConfigsClient.DeleteAnnotationConfigV1AnnotationConfigsConfigIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationConfigsClient
    {
        /// <summary>
        /// Delete an annotation configuration
        /// </summary>
        /// <param name="configId">
        /// ID of the annotation configuration
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteAnnotationConfigResponseBody> DeleteAnnotationConfigV1AnnotationConfigsConfigIdDeleteAsync(
            string configId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}