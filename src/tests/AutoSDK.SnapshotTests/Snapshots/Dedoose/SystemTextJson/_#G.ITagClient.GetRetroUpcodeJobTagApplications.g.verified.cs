//HintName: G.ITagClient.GetRetroUpcodeJobTagApplications.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// GetRetroUpcodeJobTagApplications<br/>
        /// GetRetroUpcodeJobTagApplications
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetRetroUpcodeJobTagApplicationsAsync(
            global::G.GetRetroUpcodeJobTagApplicationsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetRetroUpcodeJobTagApplications<br/>
        /// GetRetroUpcodeJobTagApplications
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetRetroUpcodeJobTagApplicationsAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}