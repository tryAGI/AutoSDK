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
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagVOs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TagImportVO> TagVOs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartImportTagsJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="tagVOs"></param>
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