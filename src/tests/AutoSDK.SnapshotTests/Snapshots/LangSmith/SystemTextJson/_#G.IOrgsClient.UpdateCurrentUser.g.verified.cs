//HintName: G.IOrgsClient.UpdateCurrentUser.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update Current User<br/>
        /// Update a user's full_name/password (basic auth only)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateCurrentUserApiV1OrgsMembersBasicPatchResponse> UpdateCurrentUserAsync(
            global::G.BasicAuthUserPatch request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Current User<br/>
        /// Update a user's full_name/password (basic auth only)
        /// </summary>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateCurrentUserApiV1OrgsMembersBasicPatchResponse> UpdateCurrentUserAsync(
            string? password = default,
            string? fullName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}