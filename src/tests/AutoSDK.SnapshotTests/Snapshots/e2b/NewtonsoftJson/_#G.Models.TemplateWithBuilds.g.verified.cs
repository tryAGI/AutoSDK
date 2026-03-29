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
        [global::Newtonsoft.Json.JsonProperty("templateID", Required = global::Newtonsoft.Json.Required.Always)]
        public string TemplateID { get; set; } = default!;

        /// <summary>
        /// Whether the template is public or only accessible by the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Public { get; set; } = default!;

        /// <summary>
        /// Aliases of the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aliases", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Aliases { get; set; } = default!;

        /// <summary>
        /// Names of the template (namespace/alias format when namespaced)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("names", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Names { get; set; } = default!;

        /// <summary>
        /// Time when the template was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Time when the template was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Time when the template was last used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastSpawnedAt")]
        public global::System.DateTime? LastSpawnedAt { get; set; }

        /// <summary>
        /// Number of times the template was used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spawnCount", Required = global::Newtonsoft.Json.Required.Always)]
        public long SpawnCount { get; set; } = default!;

        /// <summary>
        /// List of builds for the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("builds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TemplateBuild> Builds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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