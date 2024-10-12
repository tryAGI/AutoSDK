//HintName: G.IAdminClient.AdminStartExportUsersJob.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// StartExportUsersJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AdminStartExportUsersJobAsync(
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}