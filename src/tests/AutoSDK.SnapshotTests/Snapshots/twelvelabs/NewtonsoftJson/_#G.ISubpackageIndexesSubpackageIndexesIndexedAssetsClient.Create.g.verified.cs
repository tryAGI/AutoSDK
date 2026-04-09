//HintName: G.ISubpackageIndexesSubpackageIndexesIndexedAssetsClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageIndexesSubpackageIndexesIndexedAssetsClient
    {
        /// <summary>
        /// Create an indexed asset<br/>
        /// This method indexes an uploaded asset to make it searchable and analyzable. Indexing processes your content and extracts information that enables the platform to search and analyze your videos.<br/>
        /// This operation is asynchronous. The platform returns an indexed asset ID immediately and processes your content in the background. Monitor the indexing status to know when your content is ready to use.<br/>
        /// Your asset must meet the requirements based on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements)<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#input-requirements).<br/>
        /// If you want to both search and analyze your videos, the most restrictive requirements apply.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.IndexesIndexedAssetsCreateResponse202> CreateAsync(
            string indexId,
            string xApiKey,

            global::G.CreateRequest4 request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an indexed asset<br/>
        /// This method indexes an uploaded asset to make it searchable and analyzable. Indexing processes your content and extracts information that enables the platform to search and analyze your videos.<br/>
        /// This operation is asynchronous. The platform returns an indexed asset ID immediately and processes your content in the background. Monitor the indexing status to know when your content is ready to use.<br/>
        /// Your asset must meet the requirements based on your workflow:<br/>
        /// - **Search**: [Marengo requirements](/v1.3/docs/concepts/models/marengo#video-file-requirements)<br/>
        /// - **Video analysis**: [Pegasus requirements](/v1.3/docs/concepts/models/pegasus#input-requirements).<br/>
        /// If you want to both search and analyze your videos, the most restrictive requirements apply.<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="indexId"></param>
        /// <param name="xApiKey"></param>
        /// <param name="assetId">
        /// The unique identifier of the asset to index.
        /// </param>
        /// <param name="enableVideoStream">
        /// This parameter indicates if the platform stores the video for streaming. When set to `true`, the platform stores the video, and you can retrieve its URL by calling the [`GET`](/v1.3/api-reference/videos/retrieve) method of the `/indexes/{index-id}/indexed-assets/{indexed-asset-id}` endpoint. You can then use this URL to access the stream over the &lt;a href="https://en.wikipedia.org/wiki/HTTP_Live_Streaming" target="_blank"&gt;HLS&lt;/a&gt; protocol.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.IndexesIndexedAssetsCreateResponse202> CreateAsync(
            string indexId,
            string xApiKey,
            string assetId,
            bool? enableVideoStream = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}