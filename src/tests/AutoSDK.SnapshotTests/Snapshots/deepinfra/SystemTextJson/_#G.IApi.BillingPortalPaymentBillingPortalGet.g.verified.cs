//HintName: G.IApi.BillingPortalPaymentBillingPortalGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Billing Portal
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BillingPortalOut> BillingPortalPaymentBillingPortalGetAsync(
            string? returnUrl = default,
            object? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}