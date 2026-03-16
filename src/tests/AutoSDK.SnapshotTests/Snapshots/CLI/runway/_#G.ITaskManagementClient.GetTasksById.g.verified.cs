//HintName: G.ITaskManagementClient.GetTasksById.g.cs
#nullable enable

namespace G
{
    public partial interface ITaskManagementClient
    {
        /// <summary>
        /// Get task detail<br/>
        /// Return details about a task. Consumers of this API should not expect updates more frequent than once every five seconds for a given task.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Response> GetTasksByIdAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}