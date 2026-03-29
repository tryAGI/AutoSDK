//HintName: G.Models.TemplateWithBuilds.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateWithBuilds
    {
        /// <summary>
        /// Identifier of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateID")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateID { get; set; }

        /// <summary>
        /// Whether the template is public or only accessible by the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// Aliases of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Aliases { get; set; }

        /// <summary>
        /// Names of the template (namespace/alias format when namespaced)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Names { get; set; }

        /// <summary>
        /// Time when the template was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time when the template was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Time when the template was last used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSpawnedAt")]
        public global::System.DateTime? LastSpawnedAt { get; set; }

        /// <summary>
        /// Number of times the template was used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spawnCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SpawnCount { get; set; }

        /// <summary>
        /// List of builds for the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("builds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TemplateBuild> Builds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateWithBuilds" /> class.
        /// </summary>
        /// <param name="templateID">
        /// Identifier of the template
        /// </param>
        /// <param name="public">
        /// Whether the template is public or only accessible by the team
        /// </param>
        /// <param name="aliases">
        /// Aliases of the template
        /// </param>
        /// <param name="names">
        /// Names of the template (namespace/alias format when namespaced)
        /// </param>
        /// <param name="createdAt">
        /// Time when the template was created
        /// </param>
        /// <param name="updatedAt">
        /// Time when the template was last updated
        /// </param>
        /// <param name="spawnCount">
        /// Number of times the template was used
        /// </param>
        /// <param name="builds">
        /// List of builds for the template
        /// </param>
        /// <param name="lastSpawnedAt">
        /// Time when the template was last used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateWithBuilds(
            string templateID,
            bool @public,
            global::System.Collections.Generic.IList<string> aliases,
            global::System.Collections.Generic.IList<string> names,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            long spawnCount,
            global::System.Collections.Generic.IList<global::G.TemplateBuild> builds,
            global::System.DateTime? lastSpawnedAt)
        {
            this.TemplateID = templateID ?? throw new global::System.ArgumentNullException(nameof(templateID));
            this.Public = @public;
            this.Aliases = aliases ?? throw new global::System.ArgumentNullException(nameof(aliases));
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastSpawnedAt = lastSpawnedAt;
            this.SpawnCount = spawnCount;
            this.Builds = builds ?? throw new global::System.ArgumentNullException(nameof(builds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateWithBuilds" /> class.
        /// </summary>
        public TemplateWithBuilds()
        {
        }
    }
}