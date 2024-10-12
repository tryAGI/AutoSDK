//HintName: G.IAdminClient.AdminStartExportAccountsJob.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// StartExportAccountsJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AdminStartExportAccountsJobAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}