//HintName: G.IFundWithdrawalRequestClient.CreateFundWithdrawalRequest.g.cs
#nullable enable

namespace G
{
    public partial interface IFundWithdrawalRequestClient
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
        global::System.Threading.Tasks.Task<global::G.FundWithdrawalRequestForCreateResponseDto> CreateFundWithdrawalRequestAsync(
            global::G.FundWithdrawalRequestForCreateRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="walletTypeEnumId"></param>
        /// <param name="userId"></param>
        /// <param name="requestedAmount"></param>
        /// <param name="adminCharge"></param>
        /// <param name="requestDate"></param>
        /// <param name="processedDate"></param>
        /// <param name="withdrawalStatusIdEnum"></param>
        /// <param name="btcWithdrawalAddress"></param>
        /// <param name="usdtWithdrawalAddress"></param>
        /// <param name="tusdtWithdrawalAddress"></param>
        /// <param name="cebotWithdrawalAddress"></param>
        /// <param name="withdrawalAddressIdEnum"></param>
        /// <param name="donationAmount"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FundWithdrawalRequestForCreateResponseDto> CreateFundWithdrawalRequestAsync(
            string? currentCulture = default,
            int? walletTypeEnumId = default,
            long? userId = default,
            double? requestedAmount = default,
            double? adminCharge = default,
            global::System.DateTime? requestDate = default,
            global::System.DateTime? processedDate = default,
            int? withdrawalStatusIdEnum = default,
            string? btcWithdrawalAddress = default,
            string? usdtWithdrawalAddress = default,
            string? tusdtWithdrawalAddress = default,
            string? cebotWithdrawalAddress = default,
            int? withdrawalAddressIdEnum = default,
            double? donationAmount = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}