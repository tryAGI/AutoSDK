//HintName: G.IImageTo3dClient.GetImageTo3DTask.g.cs
#nullable enable

namespace G
{
    public partial interface IImageTo3dClient
    {
        /// <summary>
        /// Retrieve an Image to 3D task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImageTo3DTask> GetImageTo3DTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}