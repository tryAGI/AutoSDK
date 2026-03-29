//HintName: G.ISubpackageEmbedSubpackageEmbedV2SubpackageEmbedV2TasksClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEmbedSubpackageEmbedV2SubpackageEmbedV2TasksClient
    {
        /// <summary>
        /// Create an async embedding task<br/>
        /// This endpoint creates embeddings for audio and video content asynchronously.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   This method only supports Marengo version 3.0 or newer.<br/>
        /// &lt;/Note&gt;<br/>
        /// **When to use this endpoint**:<br/>
        /// - Process audio or video files longer than 10 minutes<br/>
        /// - Process files up to 4 hours in duration<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        ///   **Video**:<br/>
        ///   - Minimum duration: 4 seconds<br/>
        ///   - Maximum duration: 4 hours<br/>
        ///   - Maximum file size: 4 GB<br/>
        ///   - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        ///   - Resolution: 360x360 to 5184x2160 pixels<br/>
        ///   - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1<br/>
        ///   **Audio**:<br/>
        ///   - Minimum duration: 4 seconds<br/>
        ///   - Maximum duration: 4 hours<br/>
        ///   - Maximum file size: 2 GB<br/>
        ///   - Formats: WAV (uncompressed), MP3 (lossy), FLAC (lossless)<br/>
        /// &lt;/Accordion&gt;<br/>
        ///   Creating embeddings asynchronously requires three steps:<br/>
        ///   1. Create a task using this endpoint. The platform returns a task ID.<br/>
        ///   2. Poll for the status of the task using the [`GET`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings) method of the `/embed-v2/tasks/{task_id}` endpoint. Wait until the status is `ready`.<br/>
        ///   3. Retrieve the embeddings from the response when the status is `ready` using the [`GET`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings) method of the `/embed-v2/tasks/{task_id}` endpoint.<br/>
        ///   &lt;Note title="Note"&gt;<br/>
        ///   This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        ///   &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbedV2TasksCreateResponse202> CreateAsync(
            string xApiKey,

            global::G.CreateAsyncEmbeddingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an async embedding task<br/>
        /// This endpoint creates embeddings for audio and video content asynchronously.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   This method only supports Marengo version 3.0 or newer.<br/>
        /// &lt;/Note&gt;<br/>
        /// **When to use this endpoint**:<br/>
        /// - Process audio or video files longer than 10 minutes<br/>
        /// - Process files up to 4 hours in duration<br/>
        /// &lt;Accordion title="Input requirements"&gt;<br/>
        ///   **Video**:<br/>
        ///   - Minimum duration: 4 seconds<br/>
        ///   - Maximum duration: 4 hours<br/>
        ///   - Maximum file size: 4 GB<br/>
        ///   - Formats: [FFmpeg supported formats](https://ffmpeg.org/ffmpeg-formats.html)<br/>
        ///   - Resolution: 360x360 to 5184x2160 pixels<br/>
        ///   - Aspect ratio: Between 1:1 and 1:2.4, or between 2.4:1 and 1:1<br/>
        ///   **Audio**:<br/>
        ///   - Minimum duration: 4 seconds<br/>
        ///   - Maximum duration: 4 hours<br/>
        ///   - Maximum file size: 2 GB<br/>
        ///   - Formats: WAV (uncompressed), MP3 (lossy), FLAC (lossless)<br/>
        /// &lt;/Accordion&gt;<br/>
        ///   Creating embeddings asynchronously requires three steps:<br/>
        ///   1. Create a task using this endpoint. The platform returns a task ID.<br/>
        ///   2. Poll for the status of the task using the [`GET`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings) method of the `/embed-v2/tasks/{task_id}` endpoint. Wait until the status is `ready`.<br/>
        ///   3. Retrieve the embeddings from the response when the status is `ready` using the [`GET`](/v1.3/api-reference/create-embeddings-v2/retrieve-embeddings) method of the `/embed-v2/tasks/{task_id}` endpoint.<br/>
        ///   &lt;Note title="Note"&gt;<br/>
        ///   This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        ///   &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="inputType">
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `audio`: Audio files<br/>
        /// - `video`: Video content
        /// </param>
        /// <param name="modelName">
        /// The model you wish to use. Only `"marengo3.0"` is supported.<br/>
        /// Default Value: marengo3.0
        /// </param>
        /// <param name="audio">
        /// This field is required if the `input_type` parameter is `audio`.
        /// </param>
        /// <param name="video">
        /// This field is required if the `input_type` parameter is `video`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbedV2TasksCreateResponse202> CreateAsync(
            string xApiKey,
            global::G.CreateAsyncEmbeddingRequestInputType inputType,
            global::G.CreateAsyncEmbeddingRequestModelName modelName = global::G.CreateAsyncEmbeddingRequestModelName.Marengo30,
            global::G.AudioInputRequest? audio = default,
            global::G.VideoInputRequest? video = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}