//HintName: G.IUsersClient.UpdateUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Updates the user’s information.<br/>
        /// Updates the specified user’s information. The user ID in the OAuth token identifies the user whose information you want to update.<br/>
        /// To include the user’s verified email address in the response, the user access token must also include the **user:read:email** scope.<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **user:edit** scope.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateUserResponse> UpdateUserAsync(
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}