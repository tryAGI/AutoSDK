//HintName: G.ISecretReferencesClient.CreateSecretReference.g.cs
#nullable enable

namespace G
{
    public partial interface ISecretReferencesClient
    {
        /// <summary>
        /// Create a Secret Reference
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSecretReferenceResponse> CreateSecretReferenceAsync(

            global::G.CreateSecretReferenceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Secret Reference
        /// </summary>
        /// <param name="organisationId">
        /// Required if not using API key auth
        /// </param>
        /// <param name="name"></param>
        /// <param name="slug">
        /// Auto-generated from name if omitted
        /// </param>
        /// <param name="description"></param>
        /// <param name="managerType"></param>
        /// <param name="authConfig"></param>
        /// <param name="secretPath"></param>
        /// <param name="secretKey"></param>
        /// <param name="allowAllWorkspaces">
        /// Cannot be true when allowed_workspaces is provided<br/>
        /// Default Value: true
        /// </param>
        /// <param name="allowedWorkspaces">
        /// Array of workspace UUIDs or slugs. Mutually exclusive with allow_all_workspaces=true.
        /// </param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSecretReferenceResponse> CreateSecretReferenceAsync(
            string name,
            global::G.CreateSecretReferenceRequestManagerType managerType,
            global::G.AuthConfig authConfig,
            string secretPath,
            global::System.Guid? organisationId = default,
            string? slug = default,
            string? description = default,
            string? secretKey = default,
            bool? allowAllWorkspaces = default,
            global::System.Collections.Generic.IList<string>? allowedWorkspaces = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}