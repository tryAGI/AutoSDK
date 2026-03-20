//HintName: G.IAdminClient.StartExportUsersJobAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// StartExportUsersJob<br/>
        /// StartExportUsersJob
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportUsersJobAsAdminAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}