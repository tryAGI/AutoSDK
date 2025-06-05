//HintName: recraft.IImageClient.RemoveBackground.g.cs
#nullable enable

namespace recraft
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Remove background
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::recraft.ProcessImageResponse> RemoveBackgroundAsync(
            global::recraft.ProcessImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove background
        /// </summary>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="responseFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::recraft.ProcessImageResponse> RemoveBackgroundAsync(
            byte[] image,
            string imagename,
            global::recraft.ResponseFormat? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}