//HintName: G.ISubpackageTasksClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageTasksClient
    {
        /// <summary>
        /// Delete a video indexing task<br/>
        /// This action cannot be undone.<br/>
        /// Note the following about deleting a video indexing task:<br/>
        /// - You can only delete video indexing tasks for which the status is `ready` or `failed`.<br/>
        /// - If the status of your video indexing task is `ready`, you must first delete the video vector associated with your video indexing task by calling the [`DELETE`](/v1.3/api-reference/videos/delete) method of the `/indexes/videos` endpoint.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TasksDeleteResponse204> DeleteAsync(
            string taskId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}