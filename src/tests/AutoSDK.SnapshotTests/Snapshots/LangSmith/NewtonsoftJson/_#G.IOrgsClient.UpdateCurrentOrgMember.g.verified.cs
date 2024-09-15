//HintName: G.IOrgsClient.UpdateCurrentOrgMember.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update Current Org Member<br/>
        /// This is used for updating a user's role (all auth modes) or full_name/password (basic auth)
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchResponse> UpdateCurrentOrgMemberAsync(
            global::System.Guid identityId,
            global::G.OrgIdentityPatch request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Current Org Member<br/>
        /// This is used for updating a user's role (all auth modes) or full_name/password (basic auth)
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchResponse> UpdateCurrentOrgMemberAsync(
            global::System.Guid identityId,
            global::G.AnyOf<string, object>? password = default,
            global::G.AnyOf<string, object>? fullName = default,
            global::G.AnyOf<global::System.Guid?, object>? roleId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}