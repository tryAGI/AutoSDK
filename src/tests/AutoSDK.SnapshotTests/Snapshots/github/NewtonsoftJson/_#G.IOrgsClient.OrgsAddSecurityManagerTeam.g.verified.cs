//HintName: G.IOrgsClient.OrgsAddSecurityManagerTeam.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Add a security manager team<br/>
        /// Adds a team as a security manager for an organization. For more information, see "[Managing security for an organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization) for an organization."<br/>
        /// The authenticated user must be an administrator for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsAddSecurityManagerTeamAsync(
            string org,
            string teamSlug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}