//HintName: G.ISubpackageEmbedSubpackageEmbedTasksClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEmbedSubpackageEmbedTasksClient
    {
        /// <summary>
        /// Create a video embedding task<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   This endpoint will be deprecated in a future version. Migrate to the [Embed API v2](/v1.3/api-reference/create-embeddings-v2) for continued support and access to new features.<br/>
        /// &lt;/Note&gt;<br/>
        /// This method creates a new video embedding task that uploads a video to the platform and creates one or multiple video embeddings.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;<br/>
        /// Upload options:<br/>
        /// - **Local file**: Use the `video_file` parameter<br/>
        /// - **Publicly accessible URL**: Use the `video_url` parameter.<br/>
        /// Specify at least one option. If both are provided, `video_url` takes precedence.<br/>
        /// Your video files must meet the [requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements).<br/>
        /// This endpoint allows you to upload files up to 2 GB in size.  To upload larger files, use the [Multipart Upload API](/v1.3/api-reference/upload-content/multipart-uploads)<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - The Marengo video understanding model generates embeddings for all modalities in the same latent space. This shared space enables any-to-any searches across different types of content.<br/>
        /// - Video embeddings are stored for seven days.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbedTasksCreateResponse200> CreateAsync(
            string xApiKey,

            global::G.CreateRequest8 request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a video embedding task<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   This endpoint will be deprecated in a future version. Migrate to the [Embed API v2](/v1.3/api-reference/create-embeddings-v2) for continued support and access to new features.<br/>
        /// &lt;/Note&gt;<br/>
        /// This method creates a new video embedding task that uploads a video to the platform and creates one or multiple video embeddings.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;<br/>
        /// Upload options:<br/>
        /// - **Local file**: Use the `video_file` parameter<br/>
        /// - **Publicly accessible URL**: Use the `video_url` parameter.<br/>
        /// Specify at least one option. If both are provided, `video_url` takes precedence.<br/>
        /// Your video files must meet the [requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements).<br/>
        /// This endpoint allows you to upload files up to 2 GB in size.  To upload larger files, use the [Multipart Upload API](/v1.3/api-reference/upload-content/multipart-uploads)<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - The Marengo video understanding model generates embeddings for all modalities in the same latent space. This shared space enables any-to-any searches across different types of content.<br/>
        /// - Video embeddings are stored for seven days.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="modelName">
        /// The name of the model you want to use. The following models are available:<br/>
        ///   - `marengo3.0`: Enhanced model with sports intelligence and extended content support.<br/>
        ///   - `Marengo-retrieval-2.7`: **Deprecation notice**: Starting mid-March 2026, your videos will be automatically reindexed to Marengo 3.0. Marengo 2.7 will be deprecated once reindexing completes. See the [Migration guide](/v1.3/docs/get-started/migration-guide) for details.
        /// </param>
        /// <param name="videoFile">
        /// Specify this parameter to upload a video from your local file system.
        /// </param>
        /// <param name="videoFilename">
        /// Specify this parameter to upload a video from your local file system.
        /// </param>
        /// <param name="videoUrl">
        /// Specify this parameter to upload a video from a publicly accessible URL.
        /// </param>
        /// <param name="videoStartOffsetSec">
        /// The start offset in seconds from the beginning of the video where processing should begin. Specifying 0 means starting from the beginning of the video.<br/>
        /// **Default**: 0<br/>
        /// **Min**: 0<br/>
        /// **Max**: Duration of the video minus video_clip_length
        /// </param>
        /// <param name="videoEndOffsetSec">
        /// The end offset in seconds from the beginning of the video where processing should stop.<br/>
        /// Ensure the following when you specify this parameter:<br/>
        /// - The end offset does not exceed the total duration of the video file.<br/>
        /// - The end offset is greater than the start offset.<br/>
        /// - You must set both the start and end offsets. Setting only one of these offsets is not permitted, resulting in an error.<br/>
        /// **Min**: video_start_offset + video_clip_length<br/>
        /// **Max**: Duration of the video file
        /// </param>
        /// <param name="videoClipLength">
        /// The desired duration in seconds for each clip for which the platform generates an embedding. Ensure that the clip length does not exceed the interval between the start and end offsets.<br/>
        /// **Default**: 6<br/>
        /// **Min**: 2<br/>
        /// **Max**: 10
        /// </param>
        /// <param name="videoEmbeddingScope">
        /// Defines the scope of video embedding generation. Valid values are the following:<br/>
        /// - `clip`: Creates embeddings for each video segment of `video_clip_length` seconds, from `video_start_offset_sec` to `video_end_offset_sec`.<br/>
        /// - `clip` and `video`: Creates embeddings for video segments and the entire video. Use the `video` scope for videos up to 10-30 seconds to maintain optimal performance.<br/>
        /// To create embeddings for segments and the entire video in the same request, include this parameter twice as shown below:<br/>
        /// ```json<br/>
        /// --form video_embedding_scope=clip \<br/>
        /// --form video_embedding_scope=video<br/>
        /// ```<br/>
        /// **Default**: `clip`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbedTasksCreateResponse200> CreateAsync(
            string xApiKey,
            string modelName,
            byte[]? videoFile = default,
            string? videoFilename = default,
            string? videoUrl = default,
            double? videoStartOffsetSec = default,
            double? videoEndOffsetSec = default,
            double? videoClipLength = default,
            global::System.Collections.Generic.IList<global::G.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItems>? videoEmbeddingScope = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}