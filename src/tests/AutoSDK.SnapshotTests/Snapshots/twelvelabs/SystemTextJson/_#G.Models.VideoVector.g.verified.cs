//HintName: G.Models.VideoVector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A video object that contains information about the video.
    /// </summary>
    public sealed partial class VideoVector
    {
        /// <summary>
        /// A string representing the unique identifier of a video. The platform creates a new `video_vector` object and assigns it a unique identifier when the video has successfully been indexed. Note that video IDs are different from task IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the video indexing task was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the video indexing task object was last updated. The platform updates this field every time the video indexing task transitions to a different state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the video indexing task has been completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexed_at")]
        public string? IndexedAt { get; set; }

        /// <summary>
        /// System-generated metadata about the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_metadata")]
        public global::G.VideoVectorSystemMetadata? SystemMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoVector" /> class.
        /// </summary>
        /// <param name="id">
        /// A string representing the unique identifier of a video. The platform creates a new `video_vector` object and assigns it a unique identifier when the video has successfully been indexed. Note that video IDs are different from task IDs.
        /// </param>
        /// <param name="createdAt">
        /// A string indicating the date and time, in the RFC RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the video indexing task was created.
        /// </param>
        /// <param name="updatedAt">
        /// A string indicating the date and time, in the RFC RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the video indexing task object was last updated. The platform updates this field every time the video indexing task transitions to a different state.
        /// </param>
        /// <param name="indexedAt">
        /// A string indicating the date and time, in the RFC RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the video indexing task has been completed.
        /// </param>
        /// <param name="systemMetadata">
        /// System-generated metadata about the video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoVector(
            string? id,
            string? createdAt,
            string? updatedAt,
            string? indexedAt,
            global::G.VideoVectorSystemMetadata? systemMetadata)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.IndexedAt = indexedAt;
            this.SystemMetadata = systemMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoVector" /> class.
        /// </summary>
        public VideoVector()
        {
        }
    }
}