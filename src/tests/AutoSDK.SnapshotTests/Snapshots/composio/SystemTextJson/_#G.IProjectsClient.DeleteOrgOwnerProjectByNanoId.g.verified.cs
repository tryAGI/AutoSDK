//HintName: G.IProjectsClient.DeleteOrgOwnerProjectByNanoId.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete a project<br/>
        /// Soft-deletes a project within the organization by its unique identifier. When a project is deleted, it is marked as deleted but not immediately removed from the database. This operation affects all resources associated with the project including API keys, webhook configurations, and connected services. This action cannot be undone through the API.
        /// </summary>
        /// <param name="nanoId">
        /// Unique identifier (Nano ID) of the project to delete<br/>
        /// Example: proj_abc123xyz456
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteOrgOwnerProjectByNanoIdResponse> DeleteOrgOwnerProjectByNanoIdAsync(
            string nanoId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}