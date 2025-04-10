//HintName: G.IDiscountsClient.UpdateDiscount.g.cs
#nullable enable

namespace G
{
    public partial interface IDiscountsClient
    {
        /// <summary>
        /// Update Discount<br/>
        /// Updates a discount by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateDiscountAsync(
            long id,
            global::G.DiscountDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Discount<br/>
        /// Updates a discount by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="productId"></param>
        /// <param name="rankId"></param>
        /// <param name="startAt"></param>
        /// <param name="endAt"></param>
        /// <param name="percentage"></param>
        /// <param name="isActive"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateDiscountAsync(
            long id,
            long? productId,
            long? rankId,
            global::System.DateTime? startAt,
            global::System.DateTime? endAt,
            double percentage,
            bool isActive,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}