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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public double Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Owner { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SimpleUser Creator { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Public { get; set; } = default!;

        /// <summary>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("closed_at")]
        public global::System.DateTime? ClosedAt { get; set; }

        /// <summary>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("short_description")]
        public string? ShortDescription { get; set; }

        /// <summary>
        /// Example: 2022-04-28T12:00:00Z
        /// </summary>
        /// <example>2022-04-28T12:00:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_by")]
        public global::G.NullableSimpleUser? DeletedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="closedAt">
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="createdAt">
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="number"></param>
        /// <param name="shortDescription"></param>
        /// <param name="deletedAt">
        /// Example: 2022-04-28T12:00:00Z
        /// </param>
        /// <param name="deletedBy">
        /// A GitHub user.
        /// </param>
        public ProjectsV2(
            double id,
            string nodeId,
            global::G.SimpleUser owner,
            global::G.SimpleUser creator,
            string title,
            bool @public,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int number,
            string? description,
            global::System.DateTime? closedAt,
            string? shortDescription,
            global::System.DateTime? deletedAt,
            global::G.NullableSimpleUser? deletedBy)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Public = @public;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Number = number;
            this.Description = description;
            this.ClosedAt = closedAt;
            this.ShortDescription = shortDescription;
            this.DeletedAt = deletedAt;
            this.DeletedBy = deletedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsV2" /> class.
        /// </summary>
        public ProjectsV2()
        {
        }
    }
}