//HintName: G.IProjectsClient.RetrieveProjectApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Retrieves an API key in the project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="keyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectApiKey> RetrieveProjectApiKeyAsync(
            string projectId,
            string keyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}