//HintName: G.ISubpackageTasksClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageTasksClient
    {
        /// <summary>
        /// Create a video indexing task<br/>
        /// This method creates a video indexing task that uploads and indexes a video in a single operation.<br/>
        /// &lt;Warning title="Legacy endpoint"&gt;<br/>
        /// This endpoint bundles two operations (upload and indexing) together. In the next major API release, this endpoint will be removed in favor of a separated workflow:<br/>
        /// 1. Upload your video using the [`POST /assets`](/v1.3/api-reference/upload-content/direct-uploads/create) endpoint<br/>
        /// 2. Index the uploaded video using the [`POST /indexes/{index-id}/indexed-assets`](/v1.3/api-reference/index-content/create) endpoint<br/>
        /// This separation provides better control, reusability of assets, and improved error handling. New implementations should use the new workflow.<br/>
        /// &lt;/Warning&gt;<br/>
        /// Upload options:<br/>
        /// - **Local file**: Use the `video_file` parameter.<br/>
        /// - **Publicly accessible URL**: Use the `video_url` parameter.<br/>
        /// Your video files must meet requirements based on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements).<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#video-file-requirements).<br/>
        /// - If you want to both search and analyze your videos, the most restrictive requirements apply.<br/>
        /// - This method allows you to upload files up to 2 GB in size. To upload larger files, use the [Multipart Upload API](/v1.3/api-reference/upload-content/multipart-uploads)<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TasksCreateResponse200> CreateAsync(
            string xApiKey,

            global::G.CreateRequest3 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a video indexing task<br/>
        /// This method creates a video indexing task that uploads and indexes a video in a single operation.<br/>
        /// &lt;Warning title="Legacy endpoint"&gt;<br/>
        /// This endpoint bundles two operations (upload and indexing) together. In the next major API release, this endpoint will be removed in favor of a separated workflow:<br/>
        /// 1. Upload your video using the [`POST /assets`](/v1.3/api-reference/upload-content/direct-uploads/create) endpoint<br/>
        /// 2. Index the uploaded video using the [`POST /indexes/{index-id}/indexed-assets`](/v1.3/api-reference/index-content/create) endpoint<br/>
        /// This separation provides better control, reusability of assets, and improved error handling. New implementations should use the new workflow.<br/>
        /// &lt;/Warning&gt;<br/>
        /// Upload options:<br/>
        /// - **Local file**: Use the `video_file` parameter.<br/>
        /// - **Publicly accessible URL**: Use the `video_url` parameter.<br/>
        /// Your video files must meet requirements based on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements).<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#video-file-requirements).<br/>
        /// - If you want to both search and analyze your videos, the most restrictive requirements apply.<br/>
        /// - This method allows you to upload files up to 2 GB in size. To upload larger files, use the [Multipart Upload API](/v1.3/api-reference/upload-content/multipart-uploads)<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="indexId">
        /// The unique identifier of the index to which the video is being uploaded.
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
        /// <param name="enableVideoStream">
        /// This parameter indicates if the platform stores the video for streaming. When set to `true`, the platform stores the video, and you can retrieve its URL by calling the [`GET`](/v1.3/api-reference/videos/retrieve) method of the `/indexes/{index-id}/videos/{video-id}` endpoint. You can then use this URL to access the stream over the &lt;a href="https://en.wikipedia.org/wiki/HTTP_Live_Streaming" target="_blank"&gt;HLS&lt;/a&gt; protocol.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your videos. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float` or `boolean`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TasksCreateResponse200> CreateAsync(
            string xApiKey,
            string indexId,
            byte[]? videoFile = default,
            string? videoFilename = default,
            string? videoUrl = default,
            bool? enableVideoStream = default,
            string? userMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}