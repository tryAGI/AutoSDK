//HintName: G.IServiceTokensClient.DeleteServiceTokenId.g.cs
#nullable enable

namespace G
{
    public partial interface IServiceTokensClient
    {
        /// <summary>
        /// Delete service_token<br/>
        /// Delete a service_token object by its id
        /// </summary>
        /// <param name="serviceTokenId">
        /// ServiceToken id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ServiceToken> DeleteServiceTokenIdAsync(
            global::System.Guid serviceTokenId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}