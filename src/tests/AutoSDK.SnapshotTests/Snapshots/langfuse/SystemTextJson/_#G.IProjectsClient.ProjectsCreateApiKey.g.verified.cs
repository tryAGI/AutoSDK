//HintName: G.IProjectsClient.ProjectsCreateApiKey.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create a new API key for a project (requires organization-scoped API key)
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKeyResponse> ProjectsCreateApiKeyAsync(
            string projectId,

            global::G.ProjectsCreateApiKeyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new API key for a project (requires organization-scoped API key)
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="note">
        /// Optional note for the API key
        /// </param>
        /// <param name="publicKey">
        /// Optional predefined public key. Must start with 'pk-lf-'. If provided, secretKey must also be provided.
        /// </param>
        /// <param name="secretKey">
        /// Optional predefined secret key. Must start with 'sk-lf-'. If provided, publicKey must also be provided.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiKeyResponse> ProjectsCreateApiKeyAsync(
            string projectId,
            string? note = default,
            string? publicKey = default,
            string? secretKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}