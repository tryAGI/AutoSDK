//HintName: G.IApi.GetTask.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// use the task_id created by createTask to get the status of a task
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTaskResponse> GetTaskAsync(
            string taskId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}