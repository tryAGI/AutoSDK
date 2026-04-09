//HintName: G.IAnnotationsClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// Delete annotation<br/>
        /// Delete an annotation. This action can't be undone!
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            int id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}