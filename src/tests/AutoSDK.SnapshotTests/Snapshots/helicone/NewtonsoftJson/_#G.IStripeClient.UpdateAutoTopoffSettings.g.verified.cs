//HintName: G.IStripeClient.UpdateAutoTopoffSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IStripeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoTopoffSettings> UpdateAutoTopoffSettingsAsync(

            global::G.UpdateAutoTopoffSettingsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="thresholdCents"></param>
        /// <param name="topoffAmountCents"></param>
        /// <param name="stripePaymentMethodId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoTopoffSettings> UpdateAutoTopoffSettingsAsync(
            bool enabled,
            double thresholdCents,
            double topoffAmountCents,
            string stripePaymentMethodId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}