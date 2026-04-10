//HintName: G.IViewsClient.List2.g.cs
#nullable enable

namespace G
{
    public partial interface IViewsClient
    {
        /// <summary>
        /// List views<br/>
        /// List all views for a specific project.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.View>> List2Async(
            int? project = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}