//HintName: G.IToolkitsClient.PostToolkitsMulti.g.cs
#nullable enable

namespace G
{
    public partial interface IToolkitsClient
    {
        /// <summary>
        /// Fetch multiple toolkits<br/>
        /// Retrieves a comprehensive list of toolkits of their latest versions that are available to the authenticated project. Toolkits represent integration points with external services and applications, each containing a collection of tools and triggers. This endpoint supports filtering by category and management type, as well as different sorting options. You can optionally specify a list of toolkit slugs to fetch specific toolkits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolkitsMultiResponse> PostToolkitsMultiAsync(

            global::G.PostToolkitsMultiRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fetch multiple toolkits<br/>
        /// Retrieves a comprehensive list of toolkits of their latest versions that are available to the authenticated project. Toolkits represent integration points with external services and applications, each containing a collection of tools and triggers. This endpoint supports filtering by category and management type, as well as different sorting options. You can optionally specify a list of toolkit slugs to fetch specific toolkits.
        /// </summary>
        /// <param name="toolkits">
        /// Array of toolkit slug identifiers to retrieve<br/>
        /// Example: [github, slack, gmail]
        /// </param>
        /// <param name="category">
        /// Category ID or name to filter toolkits by<br/>
        /// Example: productivity
        /// </param>
        /// <param name="managedBy">
        /// Entity responsible for managing the toolkits
        /// </param>
        /// <param name="sortBy">
        /// Determines how toolkits should be sorted in the response
        /// </param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostToolkitsMultiResponse> PostToolkitsMultiAsync(
            global::System.Collections.Generic.IList<string>? toolkits = default,
            string? category = default,
            global::G.PostToolkitsMultiRequestManagedBy? managedBy = default,
            global::G.PostToolkitsMultiRequestSortBy? sortBy = default,
            double? limit = default,
            string? cursor = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}