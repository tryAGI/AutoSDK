//HintName: G.IProjectsClient.GetProjectMembers.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get Project Members<br/>
        /// Retrieve a list of members for a specific project.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetProjectMembersResponse> GetProjectMembersAsync(
            string orgId,
            string projectId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}