//HintName: G.IWorkflowsClient.ListWorkflows.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// List user workflows<br/>
        /// List workflows for the authenticated user with optional search and filtering.<br/>
        /// **Features:**<br/>
        /// - Paginated results with cursor-based pagination<br/>
        /// - Search by workflow name or title<br/>
        /// - Filter by model endpoints used in the workflow<br/>
        /// **Authentication:** Required. Returns only workflows owned by the authenticated user.<br/>
        /// **Common Use Cases:**<br/>
        /// - Display user's workflow library<br/>
        /// - Search for specific workflows<br/>
        /// - Find workflows using particular models<br/>
        ///     
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="search">
        /// Search by workflow name or title<br/>
        /// Example: image generation
        /// </param>
        /// <param name="usedEndpointIds">
        /// Filter by model endpoint IDs used in the workflow. Can be a single value or comma-separated values.<br/>
        /// Example: [fal-ai/flux/dev]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListWorkflowsResponse> ListWorkflowsAsync(
            int? limit = default,
            string? cursor = default,
            string? search = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? usedEndpointIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}