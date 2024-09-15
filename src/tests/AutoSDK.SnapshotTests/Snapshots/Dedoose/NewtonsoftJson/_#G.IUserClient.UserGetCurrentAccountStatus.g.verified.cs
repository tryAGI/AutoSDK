//HintName: G.IUserClient.UserGetCurrentAccountStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// GetCurrentAccountStatus.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserAccountVO> UserGetCurrentAccountStatusAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}