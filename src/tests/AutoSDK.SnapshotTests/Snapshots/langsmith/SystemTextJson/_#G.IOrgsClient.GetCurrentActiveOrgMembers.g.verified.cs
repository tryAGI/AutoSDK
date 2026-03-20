//HintName: G.IOrgsClient.GetCurrentActiveOrgMembers.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Current Active Org Members
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="emails">
        /// Default Value: []
        /// </param>
        /// <param name="lsUserIds">
        /// Default Value: []
        /// </param>
        /// <param name="userIds">
        /// Default Value: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.OrgMemberIdentity>> GetCurrentActiveOrgMembersAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? emails = default,
            global::System.Collections.Generic.IList<global::System.Guid>? lsUserIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? userIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}