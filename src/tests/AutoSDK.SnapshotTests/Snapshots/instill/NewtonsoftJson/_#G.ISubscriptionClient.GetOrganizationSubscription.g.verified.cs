//HintName: G.ISubscriptionClient.GetOrganizationSubscription.g.cs
#nullable enable

namespace G
{
    public partial interface ISubscriptionClient
    {
        /// <summary>
        /// Get the subscription of an organization<br/>
        /// Returns the subscription details of an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetOrganizationSubscriptionResponse> GetOrganizationSubscriptionAsync(
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}