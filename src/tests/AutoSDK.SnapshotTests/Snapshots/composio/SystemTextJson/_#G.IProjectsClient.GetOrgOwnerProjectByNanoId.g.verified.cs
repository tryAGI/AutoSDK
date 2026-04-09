//HintName: G.IProjectsClient.GetOrgOwnerProjectByNanoId.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project details by ID With Org Api key<br/>
        /// Retrieves detailed information about a specific project using its unique identifier. This endpoint provides complete project configuration including webhook URLs, creation and update timestamps, and webhook secrets. Use this endpoint to inspect project settings or verify project configuration.
        /// </summary>
        /// <param name="nanoId">
        /// Unique identifier (Nano ID) of the project to retrieve<br/>
        /// Example: proj_abc123xyz456
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetOrgOwnerProjectByNanoIdResponse> GetOrgOwnerProjectByNanoIdAsync(
            string nanoId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}