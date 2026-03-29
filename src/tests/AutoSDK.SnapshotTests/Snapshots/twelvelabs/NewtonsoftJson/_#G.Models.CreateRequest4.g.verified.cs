//HintName: G.Models.CreateRequest4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest4
    {
        /// <summary>
        /// The unique identifier of the asset to index.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AssetId { get; set; } = default!;

        /// <summary>
        /// This parameter indicates if the platform stores the video for streaming. When set to `true`, the platform stores the video, and you can retrieve its URL by calling the [`GET`](/v1.3/api-reference/videos/retrieve) method of the `/indexes/{index-id}/indexed-assets/{indexed-asset-id}` endpoint. You can then use this URL to access the stream over the &lt;a href="https://en.wikipedia.org/wiki/HTTP_Live_Streaming" target="_blank"&gt;HLS&lt;/a&gt; protocol.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_video_stream")]
        public bool? EnableVideoStream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest4" /> class.
        /// </summary>
        /// <param name="assetId">
        /// The unique identifier of the asset to index.
        /// </param>
        /// <param name="enableVideoStream">
        /// This parameter indicates if the platform stores the video for streaming. When set to `true`, the platform stores the video, and you can retrieve its URL by calling the [`GET`](/v1.3/api-reference/videos/retrieve) method of the `/indexes/{index-id}/indexed-assets/{indexed-asset-id}` endpoint. You can then use this URL to access the stream over the &lt;a href="https://en.wikipedia.org/wiki/HTTP_Live_Streaming" target="_blank"&gt;HLS&lt;/a&gt; protocol.<br/>
        /// Default Value: false
        /// </param>
        public CreateRequest4(
            string assetId,
            bool? enableVideoStream)
        {
            this.AssetId = assetId ?? throw new global::System.ArgumentNullException(nameof(assetId));
            this.EnableVideoStream = enableVideoStream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest4" /> class.
        /// </summary>
        public CreateRequest4()
        {
        }
    }
}