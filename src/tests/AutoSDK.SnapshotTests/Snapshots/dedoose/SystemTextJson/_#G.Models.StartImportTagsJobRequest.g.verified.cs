//HintName: G.Models.StartImportTagsJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartImportTagsJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagVOs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TagImportVO> TagVOs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartImportTagsJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="tagVOs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartImportTagsJobRequest(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::G.TagImportVO> tagVOs)
        {
            this.ProjectId = projectId;
            this.TagVOs = tagVOs ?? throw new global::System.ArgumentNullException(nameof(tagVOs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartImportTagsJobRequest" /> class.
        /// </summary>
        public StartImportTagsJobRequest()
        {
        }
    }
}