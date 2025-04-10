//HintName: G.IWalletFundingRequestClient.GetByWalletTypePaginated.g.cs
#nullable enable

namespace G
{
    public partial interface IWalletFundingRequestClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="isReceived"></param>
        /// <param name="userId"></param>
        /// <param name="username"></param>
        /// <param name="bTCAddress"></param>
        /// <param name="walletTypeIdEnum"></param>
        /// <param name="walletTypeIdEnum2"></param>
        /// <param name="walletTypeIdEnum3"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchFilterFields"></param>
        /// <param name="searchFiltersValue"></param>
        /// <param name="whereFilterFields"></param>
        /// <param name="whereFilterOperations"></param>
        /// <param name="whereFilterValues"></param>
        /// <param name="orderBy"></param>
        /// <param name="orderByDesc"></param>
        /// <param name="whereFilterAnd"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedResponseDtoOfWalletFundingRequestForPaginatedListResponseDto> GetByWalletTypePaginatedAsync(
            global::System.DateTime? fromDate = default,
            global::System.DateTime? toDate = default,
            bool? isReceived = default,
            long? userId = default,
            string? username = default,
            string? bTCAddress = default,
            int? walletTypeIdEnum = default,
            int? walletTypeIdEnum2 = default,
            int? walletTypeIdEnum3 = default,
            int? pageNumber = default,
            int? pageSize = default,
            string? searchFilterFields = default,
            string? searchFiltersValue = default,
            string? whereFilterFields = default,
            string? whereFilterOperations = default,
            string? whereFilterValues = default,
            string? orderBy = default,
            bool? orderByDesc = default,
            bool? whereFilterAnd = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}