//HintName: G.IUserClient.UpdateCurrentUserPassword.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// UpdateCurrentUserPassword<br/>
        /// UpdateCurrentUserPassword
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCurrentUserPasswordAsync(
            global::G.UpdateCurrentUserPasswordRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateCurrentUserPassword<br/>
        /// UpdateCurrentUserPassword
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="encryptedPass"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCurrentUserPasswordAsync(
            global::System.Guid userId,
            string encryptedPass,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}