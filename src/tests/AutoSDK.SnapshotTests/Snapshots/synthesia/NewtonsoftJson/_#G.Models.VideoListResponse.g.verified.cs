//HintName: G.Models.VideoListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("videos")]
        public global::System.Collections.Generic.IList<global::G.VideoResponse>? Videos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextOffset")]
        public int? NextOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoListResponse" /> class.
        /// </summary>
        /// <param name="videos"></param>
        /// <param name="nextOffset"></param>
        public VideoListResponse(
            global::System.Collections.Generic.IList<global::G.VideoResponse>? videos,
            int? nextOffset)
        {
            this.Videos = videos;
            this.NextOffset = nextOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoListResponse" /> class.
        /// </summary>
        public VideoListResponse()
        {
        }
    }
}