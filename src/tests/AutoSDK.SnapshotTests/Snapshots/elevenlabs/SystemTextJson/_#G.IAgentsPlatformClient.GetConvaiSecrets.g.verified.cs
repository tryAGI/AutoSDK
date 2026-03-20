//HintName: G.IAgentsPlatformClient.GetConvaiSecrets.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Convai Workspace Secrets<br/>
        /// Get all workspace secrets for the user
        /// </summary>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100. If not provided, returns all secrets.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetWorkspaceSecretsResponseModel> GetConvaiSecretsAsync(
            int? pageSize = default,
            string? cursor = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}