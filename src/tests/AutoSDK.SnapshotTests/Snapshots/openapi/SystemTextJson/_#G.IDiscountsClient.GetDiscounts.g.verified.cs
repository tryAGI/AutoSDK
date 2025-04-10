//HintName: G.IDiscountsClient.GetDiscounts.g.cs
#nullable enable

namespace G
{
    public partial interface IDiscountsClient
    {
        /// <summary>
        /// Get Discounts<br/>
        /// Returns all discounts.
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DiscountDto>> GetDiscountsAsync(
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}