//HintName: G.IFeedsClient.FeedsListFeeds.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedsClient
    {
        /// <summary>
        /// List Feeds<br/>
        /// List all feeds with optional filters and pagination
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedsListFeedsResponse> FeedsListFeedsAsync(
            string? projectId = default,
            string? name = default,
            string? limit = default,
            global::G.OneOf<string, double?>? offset = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}