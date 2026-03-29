//HintName: G.IImagesClient.ImageCreateImageCreatePost.g.cs
#nullable enable

namespace G
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Image Create
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImageGenerationCreateRes> ImageCreateImageCreatePostAsync(

            global::G.ImageGenerationCreateReq request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Create
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="inputs"></param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
        /// <param name="trackLlmCall">
        /// Whether to track this image generation call in the trace server<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImageGenerationCreateRes> ImageCreateImageCreatePostAsync(
            string projectId,
            global::G.ImageGenerationRequestInputs inputs,
            string? wbUserId = default,
            bool? trackLlmCall = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}