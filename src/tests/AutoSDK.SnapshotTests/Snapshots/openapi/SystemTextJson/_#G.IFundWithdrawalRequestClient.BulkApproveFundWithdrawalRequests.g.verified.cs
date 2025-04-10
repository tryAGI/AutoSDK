//HintName: G.IFundWithdrawalRequestClient.BulkApproveFundWithdrawalRequests.g.cs
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
        global::System.Threading.Tasks.Task<global::G.FundWithdrawalRequestBulkApproveResponseDto> BulkApproveFundWithdrawalRequestsAsync(
            global::G.FundWithdrawalRequestBulkApproveRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="ids"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FundWithdrawalRequestBulkApproveResponseDto> BulkApproveFundWithdrawalRequestsAsync(
            string? currentCulture = default,
            global::System.Collections.Generic.IList<long>? ids = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}