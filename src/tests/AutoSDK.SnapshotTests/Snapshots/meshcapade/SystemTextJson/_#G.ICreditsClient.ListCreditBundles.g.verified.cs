//HintName: G.ICreditsClient.ListCreditBundles.g.cs
#nullable enable

namespace G
{
    public partial interface ICreditsClient
    {
        /// <summary>
        /// List credit bundles
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListCreditBundlesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}