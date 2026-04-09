//HintName: G.ISubpackageEmbedSubpackageEmbedV2Client.Create.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEmbedSubpackageEmbedV2Client
    {
        /// <summary>
        /// Create sync embeddings<br/>
        /// This endpoint synchronously creates embeddings for multimodal content and returns the results immediately in the response.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   This method only supports Marengo version 3.0 or newer.<br/>
        /// &lt;/Note&gt;<br/>
        /// **When to use this endpoint**:<br/>
        /// - Create embeddings for text, images, audio, or video content<br/>
        /// - Retrieve immediate results without waiting for background processing<br/>
        /// - Process audio or video content up to 10 minutes in duration<br/>
        /// **Do not use this endpoint for**:<br/>
        /// - Audio or video content longer than 10 minutes. Use the [`POST`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task) method of the `/embed-v2/tasks` endpoint instead.<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        ///   **Text**:<br/>
        ///   - Maximum length: 500 tokens<br/>
        ///   **Images**:<br/>
        ///   - Formats: JPEG, PNG<br/>
        ///   - Minimum size: 128x128 pixels<br/>
        ///   - Maximum file size: 5 MB<br/>
        ///   **Audio and video**:<br/>
        ///   - Maximum duration: 10 minutes<br/>
        ///   - Maximum file size for base64 encoded strings: 36 MB<br/>
        ///   - Audio formats: WAV (uncompressed), MP3 (lossy), FLAC (lossless)<br/>
        ///   - Video formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        ///   - Video resolution: 360x360 to 5184x2160 pixels<br/>
        ///   - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1<br/>
        /// &lt;/Accordion&gt;<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingSuccessResponse> CreateAsync(
            string xApiKey,

            global::G.CreateEmbeddingsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create sync embeddings<br/>
        /// This endpoint synchronously creates embeddings for multimodal content and returns the results immediately in the response.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   This method only supports Marengo version 3.0 or newer.<br/>
        /// &lt;/Note&gt;<br/>
        /// **When to use this endpoint**:<br/>
        /// - Create embeddings for text, images, audio, or video content<br/>
        /// - Retrieve immediate results without waiting for background processing<br/>
        /// - Process audio or video content up to 10 minutes in duration<br/>
        /// **Do not use this endpoint for**:<br/>
        /// - Audio or video content longer than 10 minutes. Use the [`POST`](/v1.3/api-reference/create-embeddings-v2/create-async-embedding-task) method of the `/embed-v2/tasks` endpoint instead.<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        ///   **Text**:<br/>
        ///   - Maximum length: 500 tokens<br/>
        ///   **Images**:<br/>
        ///   - Formats: JPEG, PNG<br/>
        ///   - Minimum size: 128x128 pixels<br/>
        ///   - Maximum file size: 5 MB<br/>
        ///   **Audio and video**:<br/>
        ///   - Maximum duration: 10 minutes<br/>
        ///   - Maximum file size for base64 encoded strings: 36 MB<br/>
        ///   - Audio formats: WAV (uncompressed), MP3 (lossy), FLAC (lossless)<br/>
        ///   - Video formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        ///   - Video resolution: 360x360 to 5184x2160 pixels<br/>
        ///   - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1<br/>
        /// &lt;/Accordion&gt;<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="inputType">
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `audio`: Creates embeddings for an audio file<br/>
        /// - `video`: Creates embeddings for a video file<br/>
        /// - `image`: Creates embeddings for an image file<br/>
        /// - `text`: Creates embeddings for text input<br/>
        /// - `text_image`: Creates embeddings for text and an image<br/>
        /// - `multi_input`: Creates a single embedding from up to 10 images. You can optionally include text to provide context. To reference specific images in your text, use placeholders in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source
        /// </param>
        /// <param name="modelName">
        /// The video understanding model to use. Only "marengo3.0" is supported.<br/>
        /// Default Value: marengo3.0
        /// </param>
        /// <param name="text">
        /// This field is required if the `input_type` parameter is `text`.
        /// </param>
        /// <param name="image">
        /// This field is required if the  `input_type` parameter is `image`.
        /// </param>
        /// <param name="textImage">
        /// This field is required if the `input_type` parameter is `text_image`.
        /// </param>
        /// <param name="audio">
        /// This field is required if the `input_type` parameter is `audio`.
        /// </param>
        /// <param name="video">
        /// This field is required if the `input_type` parameter is `video`.
        /// </param>
        /// <param name="multiInput">
        /// This field is required if the `input_type` parameter is `multi_input`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingSuccessResponse> CreateAsync(
            string xApiKey,
            global::G.CreateEmbeddingsRequestInputType inputType,
            global::G.CreateEmbeddingsRequestModelName modelName = global::G.CreateEmbeddingsRequestModelName.Marengo30,
            global::G.TextInputRequest? text = default,
            global::G.ImageInputRequest? image = default,
            global::G.TextImageInputRequest? textImage = default,
            global::G.AudioInputRequest? audio = default,
            global::G.VideoInputRequest? video = default,
            global::G.MultiInputRequest? multiInput = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}