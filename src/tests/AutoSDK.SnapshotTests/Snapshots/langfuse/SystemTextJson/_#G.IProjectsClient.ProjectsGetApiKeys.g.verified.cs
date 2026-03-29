//HintName: G.IProjectsClient.ProjectsGetApiKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get all API keys for a project (requires organization-scoped API key)
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKeyList> ProjectsGetApiKeysAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}