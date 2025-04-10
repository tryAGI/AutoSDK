//HintName: G.IProductSubscriptionClient.GetProductsSubscriptionSales.g.cs
#nullable enable

namespace G
{
    public partial interface IProductSubscriptionClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="productTypeEnumId"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProductSubscriptionForSalesResponseDto> GetProductsSubscriptionSalesAsync(
            long? productId = default,
            int? productTypeEnumId = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}