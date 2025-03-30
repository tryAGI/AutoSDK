//HintName: G.IConversationalAIClient.DeleteConvaiSecretsBySecretId.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Delete Convai Workspace Secret<br/>
        /// Delete a workspace secret if it's not in use
        /// </summary>
        /// <param name="secretId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteConvaiSecretsBySecretIdAsync(
            string secretId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}