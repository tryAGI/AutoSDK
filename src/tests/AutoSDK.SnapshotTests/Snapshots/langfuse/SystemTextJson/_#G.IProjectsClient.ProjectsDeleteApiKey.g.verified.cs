//HintName: G.IProjectsClient.ProjectsDeleteApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete an API key for a project (requires organization-scoped API key)
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="apiKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKeyDeletionResponse> ProjectsDeleteApiKeyAsync(
            string projectId,
            string apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}