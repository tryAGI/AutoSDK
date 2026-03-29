//HintName: G.Models.TemplatesCreateTemplateRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create a template from an uploaded agent file
    /// </summary>
    public sealed partial class TemplatesCreateTemplateRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TemplatesCreateTemplateRequestVariant2TypeJsonConverter))]
        public global::G.TemplatesCreateTemplateRequestVariant2Type Type { get; set; }

        /// <summary>
        /// The agent file to use as a template, this should be a JSON file exported from the platform
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> AgentFile { get; set; }

        /// <summary>
        /// Optional custom name for the template. If not provided, a random name will be generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// If true, update existing custom tools source_code and json_schema (source_type cannot be changed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_existing_tools")]
        public bool? UpdateExistingTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateTemplateRequestVariant2" /> class.
        /// </summary>
        /// <param name="agentFile">
        /// The agent file to use as a template, this should be a JSON file exported from the platform
        /// </param>
        /// <param name="type"></param>
        /// <param name="name">
        /// Optional custom name for the template. If not provided, a random name will be generated.
        /// </param>
        /// <param name="updateExistingTools">
        /// If true, update existing custom tools source_code and json_schema (source_type cannot be changed)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesCreateTemplateRequestVariant2(
            global::System.Collections.Generic.Dictionary<string, object?> agentFile,
            global::G.TemplatesCreateTemplateRequestVariant2Type type,
            string? name,
            bool? updateExistingTools)
        {
            this.Type = type;
            this.AgentFile = agentFile ?? throw new global::System.ArgumentNullException(nameof(agentFile));
            this.Name = name;
            this.UpdateExistingTools = updateExistingTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateTemplateRequestVariant2" /> class.
        /// </summary>
        public TemplatesCreateTemplateRequestVariant2()
        {
        }
    }
}