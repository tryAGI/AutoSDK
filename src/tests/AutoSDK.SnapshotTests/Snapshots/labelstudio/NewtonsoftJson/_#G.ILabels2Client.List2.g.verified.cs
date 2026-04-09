//HintName: G.ILabels2Client.List2.g.cs
#nullable enable

namespace G
{
    public partial interface ILabels2Client
    {
        /// <summary>
        /// List labels<br/>
        /// List all custom labels added to your project separately from the labeling configuration.
        /// </summary>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedLabelList> List2Async(
            string? ordering = default,
            int? page = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}