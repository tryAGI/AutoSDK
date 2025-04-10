//HintName: G.IProductClient.UpdateProductOld.g.cs
#nullable enable

namespace G
{
    public partial interface IProductClient
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
        global::System.Threading.Tasks.Task<string> UpdateProductOldAsync(
            global::G.ProductForUpdateRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="productTypeEnumId"></param>
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
        global::System.Threading.Tasks.Task<string> UpdateProductOldAsync(
            string? currentCulture = default,
            long? id = default,
            string? name = default,
            double? price = default,
            int? productTypeEnumId = default,
            double? directSaleCommissionPercentage = default,
            double? dailyRewardPercentage = default,
            bool? permitsRankQualification = default,
            bool? permitsRankDirectActiveQualification = default,
            byte? validityMonths = default,
            bool? countsTowardsCommissions = default,
            double? networkVolumePercentage = default,
            double? educationPointsPercentage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}