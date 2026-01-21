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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_node_id")]
        public string? ProjectNodeId { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::G.SimpleUser? Creator { get; set; }

        /// <summary>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectsV2StatusUpdateStatusJsonConverter))]
        public global::G.ProjectsV2StatusUpdateStatus? Status { get; set; }

        /// <summary>
        /// Example: 2022-04-28
        /// </summary>
        /// <example>2022-04-28</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Example: 2022-04-28
        /// </summary>
        /// <example>2022-04-28</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_date")]
        public global::System.DateTime? TargetDate { get; set; }

        /// <summary>
        /// Body of the status update<br/>
        /// Example: The project is off to a great start!
        /// </summary>
        /// <example>The project is off to a great start!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// <param name="createdAt">
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="status"></param>
        /// <param name="startDate">
        /// Example: 2022-04-28
        /// </param>
        /// <param name="targetDate">
        /// Example: 2022-04-28
        /// </param>
        /// <param name="body">
        /// Body of the status update<br/>
        /// Example: The project is off to a great start!
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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