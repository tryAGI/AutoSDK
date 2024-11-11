//HintName: G.Models.ProjectsV2StatusUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An status update belonging to a project
    /// </summary>
    public sealed partial class ProjectsV2StatusUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public double Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_node_id")]
        public string? ProjectNodeId { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator")]
        public global::G.SimpleUser? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.ProjectsV2StatusUpdateStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_date")]
        public global::System.DateTime? TargetDate { get; set; }

        /// <summary>
        /// Body of the status update<br/>
        /// Example: The project is off to a great start!
        /// </summary>
        /// <example>The project is off to a great start!</example>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2StatusUpdate" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="projectNodeId"></param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="status"></param>
        /// <param name="startDate"></param>
        /// <param name="targetDate"></param>
        /// <param name="body">
        /// Body of the status update<br/>
        /// Example: The project is off to a great start!
        /// </param>
        public ProjectsV2StatusUpdate(
            double id,
            string nodeId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? projectNodeId,
            global::G.SimpleUser? creator,
            global::G.ProjectsV2StatusUpdateStatus? status,
            global::System.DateTime? startDate,
            global::System.DateTime? targetDate,
            string? body)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ProjectNodeId = projectNodeId;
            this.Creator = creator;
            this.Status = status;
            this.StartDate = startDate;
            this.TargetDate = targetDate;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2StatusUpdate" /> class.
        /// </summary>
        public ProjectsV2StatusUpdate()
        {
        }
    }
}