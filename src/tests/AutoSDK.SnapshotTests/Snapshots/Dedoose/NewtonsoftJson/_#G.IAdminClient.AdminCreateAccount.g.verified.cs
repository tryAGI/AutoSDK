//HintName: G.IAdminClient.AdminCreateAccount.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// CreateAccount.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="adminId"></param>
        /// <param name="credits"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AdminCreateAccountAsync(
            string? token = default,
            global::System.Guid? adminId = default,
            double? credits = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}