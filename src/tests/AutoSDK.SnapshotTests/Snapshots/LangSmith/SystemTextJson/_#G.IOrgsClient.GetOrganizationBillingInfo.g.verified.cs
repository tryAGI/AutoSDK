//HintName: G.IOrgsClient.GetOrganizationBillingInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Organization Billing Info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationBillingInfo> GetOrganizationBillingInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}