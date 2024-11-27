//HintName: G.Models.UnlinkObjectRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnlinkObjectRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memoId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid MemoId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ResourceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("excerptId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ExcerptId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("descriptorId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DescriptorId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TagId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnlinkObjectRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="tagId"></param>
        public UnlinkObjectRequest(
            global::System.Guid projectId,
            global::System.Guid memoId,
            global::System.Guid resourceId,
            global::System.Guid excerptId,
            global::System.Guid descriptorId,
            global::System.Guid tagId)
        {
            this.ProjectId = projectId;
            this.MemoId = memoId;
            this.ResourceId = resourceId;
            this.ExcerptId = excerptId;
            this.DescriptorId = descriptorId;
            this.TagId = tagId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnlinkObjectRequest" /> class.
        /// </summary>
        public UnlinkObjectRequest()
        {
        }
    }
}