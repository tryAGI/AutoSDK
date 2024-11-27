//HintName: G.IAdminClient.StartExportAccountsJobAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// StartExportAccountsJob<br/>
        /// StartExportAccountsJob
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportAccountsJobAsAdminAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}