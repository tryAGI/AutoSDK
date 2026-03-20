//HintName: G.IMusicGenerationClient.CreateMusicUpload.g.cs
#nullable enable

namespace G
{
    public partial interface IMusicGenerationClient
    {
        /// <summary>
        /// Upload Music<br/>
        /// Upload a music file to be later used for inpainting. Only available to enterprise clients with access to the inpainting feature.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MusicUploadResponse> CreateMusicUploadAsync(

            global::G.BodyUploadMusicV1MusicUploadPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Music<br/>
        /// Upload a music file to be later used for inpainting. Only available to enterprise clients with access to the inpainting feature.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="file">
        /// The audio file to upload.
        /// </param>
        /// <param name="filename">
        /// The audio file to upload.
        /// </param>
        /// <param name="extractCompositionPlan">
        /// Whether to generate and return the composition plan for the uploaded song. If True, the response will include the composition_plan but will increase the latency.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MusicUploadResponse> CreateMusicUploadAsync(
            byte[] file,
            string filename,
            string? xiApiKey = default,
            bool? extractCompositionPlan = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}