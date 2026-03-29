//HintName: G.ICreditsClient.GetCreditBundlePaymentLink.g.cs
#nullable enable

namespace G
{
    public partial interface ICreditsClient
    {
        /// <summary>
        /// Get checkout link for credit bundle
        /// </summary>
        /// <param name="bundleID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GetCreditBundlePaymentLinkAsync(
            string bundleID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}