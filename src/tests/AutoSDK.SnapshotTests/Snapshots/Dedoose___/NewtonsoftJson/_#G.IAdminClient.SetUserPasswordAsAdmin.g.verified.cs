//HintName: G.IAdminClient.SetUserPasswordAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// SetUserPassword<br/>
        /// SetUserPassword
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetUserPasswordAsAdminAsync(
            global::G.SetUserPasswordRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// SetUserPassword<br/>
        /// SetUserPassword
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="rsaEncrptedPass"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetUserPasswordAsAdminAsync(
            global::System.Guid userId,
            string rsaEncrptedPass,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}