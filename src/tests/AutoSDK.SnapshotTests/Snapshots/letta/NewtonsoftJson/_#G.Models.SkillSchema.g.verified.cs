//HintName: G.Models.SkillSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Skill schema for agent files.<br/>
    /// Skills are folders of instructions, scripts, and resources that agents can load.<br/>
    /// Either files (with SKILL.md) or source_url must be provided:<br/>
    /// - files with SKILL.md: inline skill content<br/>
    /// - source_url: reference to resolve later (e.g., 'letta:slack')<br/>
    /// - both: inline content with provenance tracking
    /// </summary>
    public sealed partial class SkillSchema
    {
        /// <summary>
        /// Skill name, also serves as unique identifier (e.g., 'slack', 'pdf')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Skill files as path -&gt; content mapping. Must include 'SKILL.md' key if provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files")]
        public global::System.Collections.Generic.Dictionary<string, string>? Files { get; set; }

        /// <summary>
        /// Source URL for skill resolution (e.g., 'letta:slack', 'anthropic:pdf', 'owner/repo/path')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillSchema" /> class.
        /// </summary>
        /// <param name="name">
        /// Skill name, also serves as unique identifier (e.g., 'slack', 'pdf')
        /// </param>
        /// <param name="files">
        /// Skill files as path -&gt; content mapping. Must include 'SKILL.md' key if provided.
        /// </param>
        /// <param name="sourceUrl">
        /// Source URL for skill resolution (e.g., 'letta:slack', 'anthropic:pdf', 'owner/repo/path')
        /// </param>
        public SkillSchema(
            string name,
            global::System.Collections.Generic.Dictionary<string, string>? files,
            string? sourceUrl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Files = files;
            this.SourceUrl = sourceUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillSchema" /> class.
        /// </summary>
        public SkillSchema()
        {
        }
    }
}