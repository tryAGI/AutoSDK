//HintName: G.IApi.EditImageGet2.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// [LEGACY] Image Editing v1 (Plus plan)<br/>
        /// Deprecated: use /v2/edit instead.<br/>
        /// This is a legacy endpoint, it is not recommended for new integrations.<br/>
        /// For new integrations, please use /v2/edit which offers all the same functionalities, plus additional AI features.
        /// </summary>
        /// <param name="apiKey">
        /// The API key to authenticate the request<br/>
        /// Example: 4a5b60936c3a934hqb3cf5838b390dc3d4dfc9da
        /// </param>
        /// <param name="templateId">
        /// The ID of the template to render<br/>
        /// Example: 592dd982-4a1b-4cd9-ab11-21481d5a0064
        /// </param>
        /// <param name="imageUrl">
        /// The image URL to render<br/>
        /// Example: https://s3.amazonaws.com/a.storyblok.com/f/191576/1024x1024/d25e1a99d7/sample-05.png
        /// </param>
        /// <param name="conceptUrl">
        /// Deprecated, use `imageUrl` instead.<br/>
        /// Example: https://s3.amazonaws.com/a.storyblok.com/f/191576/1024x1024/d25e1a99d7/sample-05.png
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> EditImageGet2Async(
            string templateId,
            string? apiKey = default,
            string? imageUrl = default,
            string? conceptUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}