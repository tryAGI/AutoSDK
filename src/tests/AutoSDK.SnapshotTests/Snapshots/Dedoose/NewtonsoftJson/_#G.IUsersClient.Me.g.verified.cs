//HintName: G.IUsersClient.Me.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get Current User<br/>
        /// Returns the current account and user data.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ValidateUserResult> MeAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}