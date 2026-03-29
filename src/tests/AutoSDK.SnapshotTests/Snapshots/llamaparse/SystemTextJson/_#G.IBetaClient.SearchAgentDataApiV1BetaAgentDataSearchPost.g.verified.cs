//HintName: G.IBetaClient.SearchAgentDataApiV1BetaAgentDataSearchPost.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Search Agent Data<br/>
        /// Search agent data with filtering, sorting, and pagination.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedResponseAgentData> SearchAgentDataApiV1BetaAgentDataSearchPostAsync(

            global::G.SearchRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Agent Data<br/>
        /// Search agent data with filtering, sorting, and pagination.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="pageSize">
        /// The maximum number of items to return. The service may return fewer than this value. If unspecified, a default page size will be used. The maximum value is typically 1000; values above this will be coerced to the maximum.
        /// </param>
        /// <param name="pageToken">
        /// A page token, received from a previous list call. Provide this to retrieve the subsequent page.
        /// </param>
        /// <param name="filter">
        /// A filter object or expression that filters resources listed in the response.
        /// </param>
        /// <param name="orderBy">
        /// A comma-separated list of fields to order by, sorted in ascending order. Use 'field_name desc' to specify descending order.
        /// </param>
        /// <param name="deploymentName">
        /// The agent deployment's name to search within
        /// </param>
        /// <param name="collection">
        /// The logical agent data collection to search within<br/>
        /// Default Value: default
        /// </param>
        /// <param name="includeTotal">
        /// Whether to include the total number of items in the response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="offset">
        /// The offset to start from. If not provided, the first page is returned<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedResponseAgentData> SearchAgentDataApiV1BetaAgentDataSearchPostAsync(
            string deploymentName,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Collections.Generic.Dictionary<string, global::G.FilterOperation>? filter = default,
            string? orderBy = default,
            string? collection = default,
            bool? includeTotal = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}