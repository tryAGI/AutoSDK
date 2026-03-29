//HintName: G.IApi.GetLipSyncTask.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get lip-sync task<br/>
        /// Query the status and result of a specific lip-sync task.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TaskResponse> GetLipSyncTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}