//HintName: G.IConversationalAIClient.EditConvaiSecretsBySecretId.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Update Convai Workspace Secret<br/>
        /// Update an existing secret for the workspace
        /// </summary>
        /// <param name="secretId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostWorkspaceSecretResponseModel> EditConvaiSecretsBySecretIdAsync(
            string secretId,
            global::G.PatchWorkspaceSecretRequest request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Convai Workspace Secret<br/>
        /// Update an existing secret for the workspace
        /// </summary>
        /// <param name="secretId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostWorkspaceSecretResponseModel> EditConvaiSecretsBySecretIdAsync(
            string secretId,
            string name,
            string value,
            string? xiApiKey = default,
            global::G.PatchWorkspaceSecretRequestType type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}