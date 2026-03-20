//HintName: G.IOrgsClient.OrgsRemoveMembershipForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Remove organization membership for a user<br/>
        /// In order to remove a user's membership with an organization, the authenticated user must be an organization owner.<br/>
        /// If the specified user is an active member of the organization, this will remove them from the organization. If the specified user has been invited to the organization, this will cancel their invitation. The specified user will receive an email notification in both cases.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsRemoveMembershipForUserAsync(
            string org,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}