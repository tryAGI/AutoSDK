//HintName: G.Models.StudioClipReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StudioClipReference
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapter_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChapterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StudioClipReferenceClipTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StudioClipReferenceClipType ClipType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClipId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_id")]
        public string? BlockId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioClipReference" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="chapterId"></param>
        /// <param name="clipType"></param>
        /// <param name="clipId"></param>
        /// <param name="blockId"></param>
        /// <param name="previewUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StudioClipReference(
            string projectId,
            string chapterId,
            global::G.StudioClipReferenceClipType clipType,
            string clipId,
            string? blockId,
            string? previewUrl)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ChapterId = chapterId ?? throw new global::System.ArgumentNullException(nameof(chapterId));
            this.ClipType = clipType;
            this.ClipId = clipId ?? throw new global::System.ArgumentNullException(nameof(clipId));
            this.BlockId = blockId;
            this.PreviewUrl = previewUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StudioClipReference" /> class.
        /// </summary>
        public StudioClipReference()
        {
        }
    }
}