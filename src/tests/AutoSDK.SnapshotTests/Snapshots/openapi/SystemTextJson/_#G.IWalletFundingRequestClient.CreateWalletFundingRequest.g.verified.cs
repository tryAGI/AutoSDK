//HintName: G.IWalletFundingRequestClient.CreateWalletFundingRequest.g.cs
#nullable enable

namespace G
{
    public partial interface IWalletFundingRequestClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WalletFundingRequestForCreateResponseDto2> CreateWalletFundingRequestAsync(
            global::G.WalletFundingRequestForCreateRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="userId"></param>
        /// <param name="amountInFiatCurrency"></param>
        /// <param name="fiatCurrencyCode"></param>
        /// <param name="cryptoCurrencyOptionEnumId"></param>
        /// <param name="orderId"></param>
        /// <param name="transactionGroupId"></param>
        /// <param name="isXTera">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.WalletFundingRequestForCreateResponseDto2> CreateWalletFundingRequestAsync(
            string? currentCulture = default,
            long? userId = default,
            double? amountInFiatCurrency = default,
            string? fiatCurrencyCode = default,
            int? cryptoCurrencyOptionEnumId = default,
            long? orderId = default,
            global::System.Guid? transactionGroupId = default,
            bool? isXTera = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}