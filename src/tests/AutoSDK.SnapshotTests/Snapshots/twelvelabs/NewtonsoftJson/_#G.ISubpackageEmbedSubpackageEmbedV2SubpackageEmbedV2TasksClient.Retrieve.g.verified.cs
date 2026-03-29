//HintName: G.ISubpackageEmbedSubpackageEmbedV2SubpackageEmbedV2TasksClient.Retrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEmbedSubpackageEmbedV2SubpackageEmbedV2TasksClient
    {
        /// <summary>
        /// Retrieve task status and results<br/>
        /// This method retrieves the status and the results of an async embedding task.<br/>
        /// **Task statuses**:<br/>
        /// - `processing`: The platform is creating the embeddings.<br/>
        /// - `ready`: Processing is complete. Embeddings are available in the response.<br/>
        /// - `failed`: The task failed. Embeddings were not created.<br/>
        /// Invoke this method repeatedly until the `status` field is `ready`. When `status` is `ready`, use the embeddings from the response.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingTaskResponse> RetrieveAsync(
            string taskId,
            string xApiKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}