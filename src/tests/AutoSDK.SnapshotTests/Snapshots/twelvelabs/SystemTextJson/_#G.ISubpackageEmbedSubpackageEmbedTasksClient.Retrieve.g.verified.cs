//HintName: G.ISubpackageEmbedSubpackageEmbedTasksClient.Retrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEmbedSubpackageEmbedTasksClient
    {
        /// <summary>
        /// Retrieve video embeddings<br/>
        /// This method retrieves embeddings for a specific video embedding task. Ensure the task status is `ready` before invoking this method. Refer to the [Retrieve the status of a video embedding tasks](/v1.3/api-reference/create-embeddings-v1/video-embeddings/retrieve-video-embedding-task-status) page for instructions on checking the task status.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="embeddingOption"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbedTasksRetrieveResponse200> RetrieveAsync(
            string taskId,
            string xApiKey,
            global::System.Collections.Generic.IList<global::G.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItems>? embeddingOption = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}