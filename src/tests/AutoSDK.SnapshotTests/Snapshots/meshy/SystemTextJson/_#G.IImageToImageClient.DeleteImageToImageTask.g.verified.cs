//HintName: G.IImageToImageClient.DeleteImageToImageTask.g.cs
#nullable enable

namespace G
{
    public partial interface IImageToImageClient
    {
        /// <summary>
        /// Delete an Image to Image task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteImageToImageTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}