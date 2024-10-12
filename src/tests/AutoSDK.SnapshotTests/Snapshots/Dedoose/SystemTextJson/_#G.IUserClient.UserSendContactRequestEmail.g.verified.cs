//HintName: G.IUserClient.UserSendContactRequestEmail.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// SendContactRequestEmail.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="institution"></param>
        /// <param name="comments"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UserSendContactRequestEmailAsync(
            string? token = default,
            string? firstname = default,
            string? lastname = default,
            string? email = default,
            string? phone = default,
            string? institution = default,
            string? comments = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}