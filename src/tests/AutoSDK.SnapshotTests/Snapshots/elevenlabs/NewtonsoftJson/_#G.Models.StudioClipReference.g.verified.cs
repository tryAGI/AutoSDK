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
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chapter_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ChapterId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clip_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StudioClipReferenceClipType ClipType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clip_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ClipId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_id")]
        public string? BlockId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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