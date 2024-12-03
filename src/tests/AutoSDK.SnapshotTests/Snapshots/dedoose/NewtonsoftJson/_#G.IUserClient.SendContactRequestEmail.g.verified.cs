//HintName: G.IUserClient.SendContactRequestEmail.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// SendContactRequestEmail<br/>
        /// SendContactRequestEmail
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SendContactRequestEmailAsync(
            global::G.SendContactRequestEmailRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// SendContactRequestEmail<br/>
        /// SendContactRequestEmail
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="institution"></param>
        /// <param name="comments"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SendContactRequestEmailAsync(
            string firstname,
            string lastname,
            string email,
            string phone,
            string institution,
            string comments,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}