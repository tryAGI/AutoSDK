//HintName: G.IWalletFundingRequestClient.GetChangellyOffersAnon.g.cs
#nullable enable

namespace G
{
    public partial interface IWalletFundingRequestClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="amount"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetChangellyOffersResponseDto> GetChangellyOffersAnonAsync(
            long? userId = default,
            double? amount = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}