//HintName: G.IAdminClient.AdminMigrateUserToAccount.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// MigrateUserToAccount.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userToBeMovedId"></param>
        /// <param name="accountIdToMoveTo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AdminMigrateUserToAccountResponse> AdminMigrateUserToAccountAsync(
            string? token = default,
            global::System.Guid? userToBeMovedId = default,
            global::System.Guid? accountIdToMoveTo = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}