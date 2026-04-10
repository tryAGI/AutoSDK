//HintName: G.Models.TemplatesCreateTemplateNoProjectRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create a template from an uploaded agent file
    /// </summary>
    public sealed partial class TemplatesCreateTemplateNoProjectRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplatesCreateTemplateNoProjectRequestVariant2TypeJsonConverter))]
        public global::G.TemplatesCreateTemplateNoProjectRequestVariant2Type Type { get; set; }

        /// <summary>
        /// The agent file to use as a template, this should be a JSON file exported from the platform
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_file", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, object?> AgentFile { get; set; } = default!;

        /// <summary>
        /// Optional custom name for the template. If not provided, a random name will be generated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// If true, update existing custom tools source_code and json_schema (source_type cannot be changed)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("update_existing_tools")]
        public bool? UpdateExistingTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateTemplateNoProjectRequestVariant2" /> class.
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
        public TemplatesCreateTemplateNoProjectRequestVariant2(
            global::System.Collections.Generic.Dictionary<string, object?> agentFile,
            global::G.TemplatesCreateTemplateNoProjectRequestVariant2Type type,
            string? name,
            bool? updateExistingTools)
        {
            this.Type = type;
            this.AgentFile = agentFile ?? throw new global::System.ArgumentNullException(nameof(agentFile));
            this.Name = name;
            this.UpdateExistingTools = updateExistingTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateTemplateNoProjectRequestVariant2" /> class.
        /// </summary>
        public TemplatesCreateTemplateNoProjectRequestVariant2()
        {
        }
    }
}