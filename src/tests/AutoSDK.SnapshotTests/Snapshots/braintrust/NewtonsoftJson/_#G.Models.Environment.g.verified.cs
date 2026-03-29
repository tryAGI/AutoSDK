//HintName: G.Models.Environment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Environment
    {
        /// <summary>
        /// Unique identifier for the environment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the organization that the environment belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrgId { get; set; } = default!;

        /// <summary>
        /// Name of the environment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A url-friendly, unique identifier for the environment within an organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Textual description of the environment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Date of environment creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Date of environment deletion, or null if the environment is still active
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_at")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the environment
        /// </param>
        /// <param name="orgId">
        /// Unique identifier for the organization that the environment belongs under
        /// </param>
        /// <param name="name">
        /// Name of the environment
        /// </param>
        /// <param name="slug">
        /// A url-friendly, unique identifier for the environment within an organization
        /// </param>
        /// <param name="description">
        /// Textual description of the environment
        /// </param>
        /// <param name="created">
        /// Date of environment creation
        /// </param>
        /// <param name="deletedAt">
        /// Date of environment deletion, or null if the environment is still active
        /// </param>
        public Environment(
            global::System.Guid id,
            global::System.Guid orgId,
            string name,
            string slug,
            string? description,
            global::System.DateTime? created,
            global::System.DateTime? deletedAt)
        {
            this.Id = id;
            this.OrgId = orgId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Description = description;
            this.Created = created;
            this.DeletedAt = deletedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment" /> class.
        /// </summary>
        public Environment()
        {
        }
    }
}