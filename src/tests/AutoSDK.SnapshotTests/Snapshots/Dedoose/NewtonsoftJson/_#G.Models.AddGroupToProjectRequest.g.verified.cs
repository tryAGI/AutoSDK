//HintName: G.Models.AddGroupToProjectRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddGroupToProjectRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groupTitle", Required = global::Newtonsoft.Json.Required.Always)]
        public string GroupTitle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groupACLId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid GroupACLId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddGroupToProjectRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="groupTitle"></param>
        /// <param name="groupACLId"></param>
        public AddGroupToProjectRequest(
            global::System.Guid projectId,
            string groupTitle,
            global::System.Guid groupACLId)
        {
            this.ProjectId = projectId;
            this.GroupTitle = groupTitle ?? throw new global::System.ArgumentNullException(nameof(groupTitle));
            this.GroupACLId = groupACLId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddGroupToProjectRequest" /> class.
        /// </summary>
        public AddGroupToProjectRequest()
        {
        }
    }
}