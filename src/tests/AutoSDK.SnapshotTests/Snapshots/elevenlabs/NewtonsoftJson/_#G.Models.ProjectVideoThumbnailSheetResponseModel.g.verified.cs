//HintName: G.Models.ProjectVideoThumbnailSheetResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectVideoThumbnailSheetResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_thumbnail_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartThumbnailIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ThumbnailCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signed_cloud_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SignedCloudUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectVideoThumbnailSheetResponseModel" /> class.
        /// </summary>
        /// <param name="startThumbnailIndex"></param>
        /// <param name="thumbnailCount"></param>
        /// <param name="signedCloudUrl"></param>
        public ProjectVideoThumbnailSheetResponseModel(
            int startThumbnailIndex,
            int thumbnailCount,
            string signedCloudUrl)
        {
            this.StartThumbnailIndex = startThumbnailIndex;
            this.ThumbnailCount = thumbnailCount;
            this.SignedCloudUrl = signedCloudUrl ?? throw new global::System.ArgumentNullException(nameof(signedCloudUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectVideoThumbnailSheetResponseModel" /> class.
        /// </summary>
        public ProjectVideoThumbnailSheetResponseModel()
        {
        }
    }
}