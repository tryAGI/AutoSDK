//HintName: G.ITagClient.GetDeleteTagByJobResponse.g.cs
#nullable enable

namespace G
{
    public partial interface ITagClient
    {
        /// <summary>
        /// GetDeleteTagByJobResponse<br/>
        /// GetDeleteTagByJobResponse
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tag> GetDeleteTagByJobResponseAsync(
            global::G.GetDeleteTagByJobResponseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetDeleteTagByJobResponse<br/>
        /// GetDeleteTagByJobResponse
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tag> GetDeleteTagByJobResponseAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}