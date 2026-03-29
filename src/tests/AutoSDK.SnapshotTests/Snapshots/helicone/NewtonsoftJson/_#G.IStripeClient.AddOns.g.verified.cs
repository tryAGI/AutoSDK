//HintName: G.IStripeClient.AddOns.g.cs
#nullable enable

namespace G
{
    public partial interface IStripeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<double> AddOnsAsync(
            global::G.AddOnsProductType productType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}