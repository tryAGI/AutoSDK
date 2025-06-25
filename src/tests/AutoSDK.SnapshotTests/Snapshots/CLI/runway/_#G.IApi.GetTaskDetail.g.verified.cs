//HintName: G.IApi.GetTaskDetail.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get task detail.<br/>
        /// Return details about a task. Updates every 5 seconds.
        /// </summary>
        /// <param name="xRunwayVersion"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTaskDetailResponse> GetTaskDetailAsync(
            global::G.GetTaskDetailXRunwayVersion xRunwayVersion,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}