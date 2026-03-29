//HintName: G.IImageTo3dClient.DeleteImageTo3DTask.g.cs
#nullable enable

namespace G
{
    public partial interface IImageTo3dClient
    {
        /// <summary>
        /// Delete an Image to 3D task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteImageTo3DTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}