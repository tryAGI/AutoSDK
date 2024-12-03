//HintName: G.IOrgsClient.AddBasicAuthMembersToCurrentOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Add Basic Auth Members To Current Org<br/>
        /// Batch add up to 500 users to the org and specified workspaces in basic auth mode.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.UserWithPassword>> AddBasicAuthMembersToCurrentOrgAsync(
            global::System.Collections.Generic.IList<global::G.BasicAuthMemberCreate> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}