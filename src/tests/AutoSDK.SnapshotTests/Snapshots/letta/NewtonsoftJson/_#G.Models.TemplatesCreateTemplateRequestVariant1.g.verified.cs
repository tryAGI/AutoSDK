//HintName: G.Models.TemplatesCreateTemplateRequestVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create a template from an existing agent
    /// </summary>
    public sealed partial class TemplatesCreateTemplateRequestVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplatesCreateTemplateRequestVariant1TypeJsonConverter))]
        public global::G.TemplatesCreateTemplateRequestVariant1Type Type { get; set; }

        /// <summary>
        /// The ID of the agent to use as a template, can be from any project
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// Optional custom name for the template. If not provided, a random name will be generated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateTemplateRequestVariant1" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent to use as a template, can be from any project
        /// </param>
        /// <param name="type"></param>
        /// <param name="name">
        /// Optional custom name for the template. If not provided, a random name will be generated.
        /// </param>
        public TemplatesCreateTemplateRequestVariant1(
            string agentId,
            global::G.TemplatesCreateTemplateRequestVariant1Type type,
            string? name)
        {
            this.Type = type;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesCreateTemplateRequestVariant1" /> class.
        /// </summary>
        public TemplatesCreateTemplateRequestVariant1()
        {
        }
    }
}