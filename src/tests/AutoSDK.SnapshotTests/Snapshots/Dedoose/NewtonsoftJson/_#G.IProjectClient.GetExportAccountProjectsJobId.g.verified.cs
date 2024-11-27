//HintName: G.IProjectClient.GetExportAccountProjectsJobId.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// GetExportAccountProjectsJobId<br/>
        /// GetExportAccountProjectsJobId
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetExportAccountProjectsJobIdAsync(
            global::G.GetExportAccountProjectsJobIdRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetExportAccountProjectsJobId<br/>
        /// GetExportAccountProjectsJobId
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetExportAccountProjectsJobIdAsync(
            global::System.Guid accountId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}