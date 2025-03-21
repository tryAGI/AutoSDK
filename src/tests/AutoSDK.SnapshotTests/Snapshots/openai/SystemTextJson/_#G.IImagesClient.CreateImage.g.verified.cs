//HintName: G.IImagesClient.CreateImage.g.cs
#nullable enable

namespace G
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Creates an image given a prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImagesResponse> CreateImageAsync(
            global::G.CreateImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates an image given a prompt.
        /// </summary>
        /// <param name="model">
        /// The model to use for image generation.<br/>
        /// Default Value: dall-e-2<br/>
        /// Example: dall-e-3
        /// </param>
        /// <param name="n">
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is supported.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="prompt">
        /// A text description of the desired image(s). The maximum length is 1000 characters for `dall-e-2` and 4000 characters for `dall-e-3`.<br/>
        /// Example: A cute baby sea otter
        /// </param>
        /// <param name="quality">
        /// The quality of the image that will be generated. `hd` creates images with finer details and greater consistency across the image. This param is only supported for `dall-e-3`.<br/>
        /// Default Value: standard<br/>
        /// Example: standard
        /// </param>
        /// <param name="responseFormat">
        /// The format in which the generated images are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated.<br/>
        /// Default Value: url<br/>
        /// Example: url
        /// </param>
        /// <param name="size">
        /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`. Must be one of `1024x1024`, `1792x1024`, or `1024x1792` for `dall-e-3` models.<br/>
        /// Default Value: 1024x1024<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="style">
        /// The style of the generated images. Must be one of `vivid` or `natural`. Vivid causes the model to lean towards generating hyper-real and dramatic images. Natural causes the model to produce more natural, less hyper-real looking images. This param is only supported for `dall-e-3`.<br/>
        /// Default Value: vivid<br/>
        /// Example: vivid
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImagesResponse> CreateImageAsync(
            string prompt,
            global::G.AnyOf<string, global::G.CreateImageRequestModel?>? model = default,
            int? n = default,
            global::G.CreateImageRequestQuality? quality = default,
            global::G.CreateImageRequestResponseFormat? responseFormat = default,
            global::G.CreateImageRequestSize? size = default,
            global::G.CreateImageRequestStyle? style = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}