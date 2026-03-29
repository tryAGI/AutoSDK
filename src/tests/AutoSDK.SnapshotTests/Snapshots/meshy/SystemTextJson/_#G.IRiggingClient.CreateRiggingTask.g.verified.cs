//HintName: G.IRiggingClient.CreateRiggingTask.g.cs
#nullable enable

namespace G
{
    public partial interface IRiggingClient
    {
        /// <summary>
        /// Create a Rigging task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateRiggingTaskAsync(

            global::G.RiggingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Rigging task
        /// </summary>
        /// <param name="inputTaskId">
        /// ID of completed task
        /// </param>
        /// <param name="modelUrl">
        /// Public URL or data URI to GLB file
        /// </param>
        /// <param name="heightMeters">
        /// Character height in meters<br/>
        /// Default Value: 1.7
        /// </param>
        /// <param name="textureImageUrl">
        /// UV-unwrapped base color texture (PNG)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateRiggingTaskAsync(
            string? inputTaskId = default,
            string? modelUrl = default,
            double? heightMeters = default,
            string? textureImageUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}