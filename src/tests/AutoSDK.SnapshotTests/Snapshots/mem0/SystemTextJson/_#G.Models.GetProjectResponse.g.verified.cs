//HintName: G.Models.GetProjectResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectResponse
    {
        /// <summary>
        /// Unique numeric identifier of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Unique string identifier of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Name of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Timestamp of when the project was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the project was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// List of members belonging to the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::G.GetProjectResponseMember>? Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique numeric identifier of the project
        /// </param>
        /// <param name="projectId">
        /// Unique string identifier of the project
        /// </param>
        /// <param name="name">
        /// Name of the project
        /// </param>
        /// <param name="description">
        /// Description of the project
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the project was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of when the project was last updated
        /// </param>
        /// <param name="members">
        /// List of members belonging to the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectResponse(
            int? id,
            string? projectId,
            string? name,
            string? description,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<global::G.GetProjectResponseMember>? members)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.Name = name;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Members = members;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectResponse" /> class.
        /// </summary>
        public GetProjectResponse()
        {
        }
    }
}