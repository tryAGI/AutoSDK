//HintName: G.IAdminClient.AdminSetUserPassword.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// SetUserPassword.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="rsaEncrptedPass"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AdminSetUserPasswordResponse> AdminSetUserPasswordAsync(
            string? token = default,
            global::System.Guid? userId = default,
            string? rsaEncrptedPass = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}