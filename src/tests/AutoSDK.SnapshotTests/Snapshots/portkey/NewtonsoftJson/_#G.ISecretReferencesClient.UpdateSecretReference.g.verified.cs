//HintName: G.ISecretReferencesClient.UpdateSecretReference.g.cs
#nullable enable

namespace G
{
    public partial interface ISecretReferencesClient
    {
        /// <summary>
        /// Update a Secret Reference
        /// </summary>
        /// <param name="secretReferenceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateSecretReferenceAsync(
            string secretReferenceId,

            global::G.UpdateSecretReferenceRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Secret Reference
        /// </summary>
        /// <param name="secretReferenceId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="authConfig">
        /// Merged with existing config, validated against existing manager_type
        /// </param>
        /// <param name="secretPath"></param>
        /// <param name="secretKey"></param>
        /// <param name="allowAllWorkspaces">
        /// When true, all workspace-specific mappings are purged
        /// </param>
        /// <param name="allowedWorkspaces">
        /// Replaces existing workspace mappings. Automatically sets allow_all_workspaces to false.
        /// </param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateSecretReferenceAsync(
            string secretReferenceId,
            string? name = default,
            string? description = default,
            object? authConfig = default,
            string? secretPath = default,
            string? secretKey = default,
            bool? allowAllWorkspaces = default,
            global::System.Collections.Generic.IList<string>? allowedWorkspaces = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}