//HintName: G.Models.AgentTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentTemplate
    {
        /// <summary>
        /// The ID of the agent template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the agent template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the agent template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The URL of the Git repository associated with the agent template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoUrl { get; set; }

        /// <summary>
        /// The root directory of the agent template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_dir")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RootDir { get; set; }

        /// <summary>
        /// The required environment variables for the agent template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_env_vars")]
        public global::System.Collections.Generic.IList<string>? RequiredEnvVars { get; set; }

        /// <summary>
        /// The dependencies of the agent template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public global::System.Collections.Generic.IList<string>? Dependencies { get; set; }

        /// <summary>
        /// The ID of the owner of the agent template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerId { get; set; }

        /// <summary>
        /// The UTC timestamp when the agent template was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The UTC timestamp when the agent template was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTemplate" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the agent template.
        /// </param>
        /// <param name="name">
        /// The name of the agent template.
        /// </param>
        /// <param name="repoUrl">
        /// The URL of the Git repository associated with the agent template.
        /// </param>
        /// <param name="rootDir">
        /// The root directory of the agent template.
        /// </param>
        /// <param name="ownerId">
        /// The ID of the owner of the agent template.
        /// </param>
        /// <param name="createdAt">
        /// The UTC timestamp when the agent template was created.
        /// </param>
        /// <param name="updatedAt">
        /// The UTC timestamp when the agent template was last updated.
        /// </param>
        /// <param name="description">
        /// The description of the agent template.
        /// </param>
        /// <param name="requiredEnvVars">
        /// The required environment variables for the agent template.
        /// </param>
        /// <param name="dependencies">
        /// The dependencies of the agent template.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTemplate(
            string id,
            string name,
            string repoUrl,
            string rootDir,
            string ownerId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            global::System.Collections.Generic.IList<string>? requiredEnvVars,
            global::System.Collections.Generic.IList<string>? dependencies)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.RepoUrl = repoUrl ?? throw new global::System.ArgumentNullException(nameof(repoUrl));
            this.RootDir = rootDir ?? throw new global::System.ArgumentNullException(nameof(rootDir));
            this.RequiredEnvVars = requiredEnvVars;
            this.Dependencies = dependencies;
            this.OwnerId = ownerId ?? throw new global::System.ArgumentNullException(nameof(ownerId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTemplate" /> class.
        /// </summary>
        public AgentTemplate()
        {
        }
    }
}