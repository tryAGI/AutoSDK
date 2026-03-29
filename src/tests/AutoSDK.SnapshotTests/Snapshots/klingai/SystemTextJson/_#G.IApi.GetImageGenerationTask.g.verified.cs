//HintName: G.IApi.GetImageGenerationTask.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get image generation task<br/>
        /// Query the status and result of a specific image generation task.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TaskResponse> GetImageGenerationTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}