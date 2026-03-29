//HintName: G.IApiKeysClient.EditKeysByApiKeyID.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Update a team API key
        /// </summary>
        /// <param name="apiKeyID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task EditKeysByApiKeyIDAsync(
            string apiKeyID,

            global::G.UpdateTeamAPIKey request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a team API key
        /// </summary>
        /// <param name="apiKeyID"></param>
        /// <param name="name">
        /// New name for the API key
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task EditKeysByApiKeyIDAsync(
            string apiKeyID,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}