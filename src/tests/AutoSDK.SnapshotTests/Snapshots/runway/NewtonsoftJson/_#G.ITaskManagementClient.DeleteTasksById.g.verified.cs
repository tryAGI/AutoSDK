//HintName: G.ITaskManagementClient.DeleteTasksById.g.cs
#nullable enable

namespace G
{
    public partial interface ITaskManagementClient
    {
        /// <summary>
        /// Cancel or delete a task<br/>
        /// Tasks that are running, pending, or throttled can be canceled by invoking this method. Invoking this method for other tasks will delete them.<br/>
        /// The output data associated with a deleted task will be deleted from persistent storage in accordance with our data retention policy. Aborted and deleted tasks will not be able to be fetched again in the future.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xRunwayVersion">
        /// Default Value: 2024-11-06
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTasksByIdAsync(
            global::System.Guid id,
            string xRunwayVersion = "2024-11-06",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}