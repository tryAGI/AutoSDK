//HintName: G.IAuthConfigsClient.GetAuthConfigsByNanoid.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthConfigsClient
    {
        /// <summary>
        /// Get single authentication configuration by ID<br/>
        /// Retrieves detailed information about a specific authentication configuration using its unique identifier.
        /// </summary>
        /// <param name="nanoid">
        /// The unique identifier of the authentication configuration to retrieve
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAuthConfigsByNanoidResponse> GetAuthConfigsByNanoidAsync(
            string nanoid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}