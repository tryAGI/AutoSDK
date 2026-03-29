//HintName: G.IStripeClient.SearchPaymentIntents.g.cs
#nullable enable

namespace G
{
    public partial interface IStripeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchKind"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StripePaymentIntentsResponse> SearchPaymentIntentsAsync(
            string searchKind,
            double? limit = default,
            string? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}