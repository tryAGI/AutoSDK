//HintName: G.IConversationalAIClient.CreateConvaiSecrets.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Create Convai Workspace Secret<br/>
        /// Create a new secret for the workspace
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostWorkspaceSecretResponseModel> CreateConvaiSecretsAsync(
            global::G.PostWorkspaceSecretRequest request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Convai Workspace Secret<br/>
        /// Create a new secret for the workspace
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostWorkspaceSecretResponseModel> CreateConvaiSecretsAsync(
            string name,
            string value,
            string? xiApiKey = default,
            global::G.PostWorkspaceSecretRequestType type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}