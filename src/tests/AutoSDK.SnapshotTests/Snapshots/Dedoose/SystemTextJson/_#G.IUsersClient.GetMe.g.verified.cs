//HintName: G.IUsersClient.GetMe.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Returns current account and user data.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ValidateUserResult> GetMeAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}