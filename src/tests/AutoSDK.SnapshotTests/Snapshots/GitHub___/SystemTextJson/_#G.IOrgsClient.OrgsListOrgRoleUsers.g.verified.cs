//HintName: G.IOrgsClient.OrgsListOrgRoleUsers.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List users that are assigned to an organization role<br/>
        /// Lists organization members that are assigned to an organization role. For more information on organization roles, see "[Using organization roles](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/using-organization-roles)."<br/>
        /// To use this endpoint, you must be an administrator for the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="roleId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.UserRoleAssignment>> OrgsListOrgRoleUsersAsync(
            string org,
            int roleId,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}