//HintName: G.Models.ReferenceVideo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReferenceVideo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_asset_id")]
        public string? ContentAssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_node_id")]
        public string? TemplateNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("studio_clip")]
        public global::G.StudioClipReference? StudioClip { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceVideo" /> class.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="contentAssetId"></param>
        /// <param name="templateNodeId"></param>
        /// <param name="studioClip"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReferenceVideo(
            string? generationId,
            string? contentAssetId,
            string? templateNodeId,
            global::G.StudioClipReference? studioClip)
        {
            this.GenerationId = generationId;
            this.ContentAssetId = contentAssetId;
            this.TemplateNodeId = templateNodeId;
            this.StudioClip = studioClip;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceVideo" /> class.
        /// </summary>
        public ReferenceVideo()
        {
        }
    }
}