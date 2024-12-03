//HintName: G.IOrgsClient.OrgsCheckMembershipForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Check organization membership for a user<br/>
        /// Check if a user is, publicly or privately, a member of the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsCheckMembershipForUserAsync(
            string org,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}