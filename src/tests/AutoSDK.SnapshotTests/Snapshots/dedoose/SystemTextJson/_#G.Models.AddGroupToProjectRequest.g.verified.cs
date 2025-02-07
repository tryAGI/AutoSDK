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
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupTitle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupACLId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid GroupACLId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddGroupToProjectRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="groupTitle"></param>
        /// <param name="groupACLId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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