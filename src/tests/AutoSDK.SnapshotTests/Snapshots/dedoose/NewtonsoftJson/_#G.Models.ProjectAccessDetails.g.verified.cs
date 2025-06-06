﻿//HintName: G.Models.ProjectAccessDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectAccessDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectTitle")]
        public string? ProjectTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groupId")]
        public global::System.Guid? GroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groupTitle")]
        public string? GroupTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accessGroupId")]
        public global::System.Guid? AccessGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAccessDetails" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectTitle"></param>
        /// <param name="groupId"></param>
        /// <param name="groupTitle"></param>
        /// <param name="accessGroupId"></param>
        public ProjectAccessDetails(
            global::System.Guid? projectId,
            string? projectTitle,
            global::System.Guid? groupId,
            string? groupTitle,
            global::System.Guid? accessGroupId)
        {
            this.ProjectId = projectId;
            this.ProjectTitle = projectTitle;
            this.GroupId = groupId;
            this.GroupTitle = groupTitle;
            this.AccessGroupId = accessGroupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAccessDetails" /> class.
        /// </summary>
        public ProjectAccessDetails()
        {
        }
    }
}