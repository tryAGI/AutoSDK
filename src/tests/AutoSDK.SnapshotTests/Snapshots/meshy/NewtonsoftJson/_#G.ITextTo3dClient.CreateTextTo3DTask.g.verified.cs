//HintName: G.ITextTo3dClient.CreateTextTo3DTask.g.cs
#nullable enable

namespace G
{
    public partial interface ITextTo3dClient
    {
        /// <summary>
        /// Create a Text to 3D task (preview or refine)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateTextTo3DTaskAsync(

            global::G.CreateTextTo3DTaskRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Text to 3D task (preview or refine)
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateTextTo3DTaskAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}