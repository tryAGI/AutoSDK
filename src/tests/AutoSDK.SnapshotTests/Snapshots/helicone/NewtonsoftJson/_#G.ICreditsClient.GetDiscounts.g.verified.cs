//HintName: G.ICreditsClient.GetDiscounts.g.cs
#nullable enable

namespace G
{
    public partial interface ICreditsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultOrgDiscountArrayString> GetDiscountsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}