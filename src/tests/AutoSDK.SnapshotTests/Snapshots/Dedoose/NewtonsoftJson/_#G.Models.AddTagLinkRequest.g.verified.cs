//HintName: G.Models.AddTagLinkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddTagLinkRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag1Id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Tag1Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag2Id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Tag2Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isParentChildLink", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsParentChildLink { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTagLinkRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="tag1Id"></param>
        /// <param name="tag2Id"></param>
        /// <param name="isParentChildLink"></param>
        public AddTagLinkRequest(
            global::System.Guid projectId,
            global::System.Guid tag1Id,
            global::System.Guid tag2Id,
            bool isParentChildLink)
        {
            this.ProjectId = projectId;
            this.Tag1Id = tag1Id;
            this.Tag2Id = tag2Id;
            this.IsParentChildLink = isParentChildLink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTagLinkRequest" /> class.
        /// </summary>
        public AddTagLinkRequest()
        {
        }
    }
}