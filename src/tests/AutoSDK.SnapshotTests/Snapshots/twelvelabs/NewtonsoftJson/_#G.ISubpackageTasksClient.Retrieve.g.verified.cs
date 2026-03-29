//HintName: G.ISubpackageTasksClient.Retrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageTasksClient
    {
        /// <summary>
        /// Retrieve a video indexing task<br/>
        /// This method retrieves a video indexing task.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TasksRetrieveResponse200> RetrieveAsync(
            string taskId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}