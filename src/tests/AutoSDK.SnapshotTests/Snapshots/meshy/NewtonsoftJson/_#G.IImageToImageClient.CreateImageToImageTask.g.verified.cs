//HintName: G.IImageToImageClient.CreateImageToImageTask.g.cs
#nullable enable

namespace G
{
    public partial interface IImageToImageClient
    {
        /// <summary>
        /// Create an Image to Image task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateImageToImageTaskAsync(

            global::G.ImageToImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Image to Image task
        /// </summary>
        /// <param name="aiModel"></param>
        /// <param name="prompt">
        /// Transformation description
        /// </param>
        /// <param name="referenceImageUrls">
        /// 1-5 reference images
        /// </param>
        /// <param name="generateMultiView">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTaskResponse> CreateImageToImageTaskAsync(
            global::G.ImageAiModel aiModel,
            string prompt,
            global::System.Collections.Generic.IList<string> referenceImageUrls,
            bool? generateMultiView = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}