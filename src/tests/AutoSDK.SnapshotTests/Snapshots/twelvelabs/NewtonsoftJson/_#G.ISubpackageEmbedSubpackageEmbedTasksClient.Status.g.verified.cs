//HintName: G.ISubpackageEmbedSubpackageEmbedTasksClient.Status.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEmbedSubpackageEmbedTasksClient
    {
        /// <summary>
        /// Retrieve the status of a video embedding task<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   This endpoint will be deprecated in a future version. Migrate to the [Embed API v2](/v1.3/api-reference/create-embeddings-v2) for continued support and access to new features.<br/>
        /// &lt;/Note&gt;<br/>
        /// This method retrieves the status of a video embedding task. Check the task status of a video embedding task to determine when you can retrieve the embedding.<br/>
        /// A task can have one of the following statuses:<br/>
        /// - `processing`: The platform is creating the embeddings.<br/>
        /// - `ready`:  Processing is complete. Retrieve the embeddings by invoking the [`GET`](/v1.3/api-reference/create-embeddings-v1/video-embeddings/retrieve-video-embeddings) method of the `/embed/tasks/{task_id} endpoint`.<br/>
        /// - `failed`: The task could not be completed, and the embeddings haven't been created.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbedTasksStatusResponse200> StatusAsync(
            string taskId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}