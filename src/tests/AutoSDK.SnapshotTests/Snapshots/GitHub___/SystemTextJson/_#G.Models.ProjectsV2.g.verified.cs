//HintName: G.Models.ProjectsV2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A projects v2 project
    /// </summary>
    public sealed partial class ProjectsV2
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
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser Owner { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimpleUser Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? ClosedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ShortDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? DeletedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="owner">
        /// A GitHub user.
        /// </param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="public"></param>
        /// <param name="closedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="number"></param>
        /// <param name="shortDescription"></param>
        /// <param name="deletedAt"></param>
        /// <param name="deletedBy">
        /// A GitHub user.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ProjectsV2(
            double id,
            string nodeId,
            global::G.SimpleUser owner,
            global::G.SimpleUser creator,
            string title,
            string? description,
            bool @public,
            global::System.DateTime? closedAt,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int number,
            string? shortDescription,
            global::System.DateTime? deletedAt,
            global::G.NullableSimpleUser? deletedBy)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Public = @public;
            this.ClosedAt = closedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Number = number;
            this.ShortDescription = shortDescription ?? throw new global::System.ArgumentNullException(nameof(shortDescription));
            this.DeletedAt = deletedAt;
            this.DeletedBy = deletedBy ?? throw new global::System.ArgumentNullException(nameof(deletedBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2" /> class.
        /// </summary>
        public ProjectsV2()
        {
        }
    }
}