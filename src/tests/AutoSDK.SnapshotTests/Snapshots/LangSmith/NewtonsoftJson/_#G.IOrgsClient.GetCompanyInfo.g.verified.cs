//HintName: G.IOrgsClient.GetCompanyInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Company Info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StripeBusinessInfoOutput> GetCompanyInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}