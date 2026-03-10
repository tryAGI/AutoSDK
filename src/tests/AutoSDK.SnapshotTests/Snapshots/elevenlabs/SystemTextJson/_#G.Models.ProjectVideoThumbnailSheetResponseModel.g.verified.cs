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
        [global::System.Text.Json.Serialization.JsonPropertyName("start_thumbnail_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartThumbnailIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ThumbnailCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_cloud_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SignedCloudUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectVideoThumbnailSheetResponseModel" /> class.
        /// </summary>
        /// <param name="startThumbnailIndex"></param>
        /// <param name="thumbnailCount"></param>
        /// <param name="signedCloudUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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