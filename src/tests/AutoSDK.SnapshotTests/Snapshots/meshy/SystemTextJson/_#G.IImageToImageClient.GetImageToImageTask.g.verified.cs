//HintName: G.IImageToImageClient.GetImageToImageTask.g.cs
#nullable enable

namespace G
{
    public partial interface IImageToImageClient
    {
        /// <summary>
        /// Retrieve an Image to Image task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImageToImageTask> GetImageToImageTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}