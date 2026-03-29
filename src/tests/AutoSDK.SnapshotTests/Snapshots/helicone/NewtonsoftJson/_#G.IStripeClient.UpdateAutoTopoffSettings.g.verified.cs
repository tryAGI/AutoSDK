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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoTopoffSettings> UpdateAutoTopoffSettingsAsync(

            global::G.UpdateAutoTopoffSettingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="thresholdCents"></param>
        /// <param name="topoffAmountCents"></param>
        /// <param name="stripePaymentMethodId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoTopoffSettings> UpdateAutoTopoffSettingsAsync(
            bool enabled,
            double thresholdCents,
            double topoffAmountCents,
            string stripePaymentMethodId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}