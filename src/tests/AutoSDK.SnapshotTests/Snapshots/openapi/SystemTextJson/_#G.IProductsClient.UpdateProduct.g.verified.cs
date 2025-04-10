//HintName: G.IProductsClient.UpdateProduct.g.cs
#nullable enable

namespace G
{
    public partial interface IProductsClient
    {
        /// <summary>
        /// Update Product<br/>
        /// Updates a product by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateProductAsync(
            long id,
            global::G.ProductDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Product<br/>
        /// Updates a product by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="requestId"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="productType"></param>
        /// <param name="directSaleCommissionPercentage"></param>
        /// <param name="dailyRewardPercentage"></param>
        /// <param name="permitsRankQualification"></param>
        /// <param name="permitsRankDirectActiveQualification"></param>
        /// <param name="validityMonths"></param>
        /// <param name="countsTowardsCommissions"></param>
        /// <param name="networkVolumePercentage"></param>
        /// <param name="educationPointsPercentage"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateProductAsync(
            long id,
            long requestId,
            string name,
            double price,
            global::G.ProductType productType,
            double directSaleCommissionPercentage,
            double dailyRewardPercentage,
            bool permitsRankQualification,
            bool permitsRankDirectActiveQualification,
            byte validityMonths,
            bool countsTowardsCommissions,
            double networkVolumePercentage,
            double educationPointsPercentage,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}