//HintName: G.IUsersClient.ResetToken.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Reset user token<br/>
        /// Reset the user token for the current user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiCurrentUserResetTokenCreateResponse> ResetTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}