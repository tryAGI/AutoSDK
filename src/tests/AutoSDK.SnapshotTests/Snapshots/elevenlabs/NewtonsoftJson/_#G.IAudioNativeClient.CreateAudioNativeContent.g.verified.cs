//HintName: G.IAudioNativeClient.CreateAudioNativeContent.g.cs
#nullable enable

namespace G
{
    public partial interface IAudioNativeClient
    {
        /// <summary>
        /// Update Audio-Native Content From Url<br/>
        /// Finds an AudioNative project matching the provided URL, extracts content from the URL, updates the project content, and queues it for conversion and auto-publishing.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AudioNativeEditContentResponseModel> CreateAudioNativeContentAsync(

            global::G.BodyUpdateAudioNativeContentFromUrlV1AudioNativeContentPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Audio-Native Content From Url<br/>
        /// Finds an AudioNative project matching the provided URL, extracts content from the URL, updates the project content, and queues it for conversion and auto-publishing.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="url">
        /// URL of the page to extract content from.
        /// </param>
        /// <param name="author">
        /// Author used in the player and inserted at the start of the uploaded article. If not provided, the default author set in the Player settings is used.
        /// </param>
        /// <param name="title">
        /// Title used in the player and inserted at the top of the uploaded article. If not provided, the default title set in the Player settings is used.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AudioNativeEditContentResponseModel> CreateAudioNativeContentAsync(
            string url,
            string? xiApiKey = default,
            string? author = default,
            string? title = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}