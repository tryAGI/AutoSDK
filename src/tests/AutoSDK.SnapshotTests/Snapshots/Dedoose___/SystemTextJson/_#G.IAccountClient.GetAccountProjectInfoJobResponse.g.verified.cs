//HintName: G.IAccountClient.GetAccountProjectInfoJobResponse.g.cs
#nullable enable

namespace G
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// GetAccountProjectInfoJobResponse<br/>
        /// GetAccountProjectInfoJobResponse
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AccountProjectInfo>> GetAccountProjectInfoJobResponseAsync(
            global::G.GetAccountProjectInfoJobResponseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetAccountProjectInfoJobResponse<br/>
        /// GetAccountProjectInfoJobResponse
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AccountProjectInfo>> GetAccountProjectInfoJobResponseAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}