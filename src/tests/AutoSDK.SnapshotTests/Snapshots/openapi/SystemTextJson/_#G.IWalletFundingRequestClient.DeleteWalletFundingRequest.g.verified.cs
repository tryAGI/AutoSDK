//HintName: G.IWalletFundingRequestClient.DeleteWalletFundingRequest.g.cs
#nullable enable

namespace G
{
    public partial interface IWalletFundingRequestClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteWalletFundingRequestAsync(
            long? id = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}