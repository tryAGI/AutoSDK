//HintName: G.IAdminClient.AdminSetAccountUserAdminStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// SetAccountUserAdminStatus.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="accountId"></param>
        /// <param name="userId"></param>
        /// <param name="isAdmin"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AdminSetAccountUserAdminStatusAsync(
            string? token = default,
            global::System.Guid? accountId = default,
            global::System.Guid? userId = default,
            bool? isAdmin = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}