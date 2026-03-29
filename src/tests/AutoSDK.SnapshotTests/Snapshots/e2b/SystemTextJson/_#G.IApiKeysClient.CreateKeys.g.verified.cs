//HintName: G.IApiKeysClient.CreateKeys.g.cs
#nullable enable

namespace G
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Create a new team API key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatedTeamAPIKey> CreateKeysAsync(

            global::G.NewTeamAPIKey request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new team API key
        /// </summary>
        /// <param name="name">
        /// Name of the API key
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreatedTeamAPIKey> CreateKeysAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}