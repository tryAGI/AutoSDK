//HintName: G.IDiscountsClient.GetDiscount.g.cs
#nullable enable

namespace G
{
    public partial interface IDiscountsClient
    {
        /// <summary>
        /// Get Discount<br/>
        /// Returns single discount by id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DiscountDto> GetDiscountAsync(
            long id,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}