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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TemplatesCreateTemplateRequestVariant1TypeJsonConverter))]
        public global::G.TemplatesCreateTemplateRequestVariant1Type Type { get; set; }

        /// <summary>
        /// The ID of the agent to use as a template, can be from any project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Optional custom name for the template. If not provided, a random name will be generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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