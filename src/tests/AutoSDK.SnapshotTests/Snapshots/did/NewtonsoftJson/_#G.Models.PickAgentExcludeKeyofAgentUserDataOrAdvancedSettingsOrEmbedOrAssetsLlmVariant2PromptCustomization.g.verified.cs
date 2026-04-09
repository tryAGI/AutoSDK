//HintName: G.Models.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced configuration for the language model.
    /// </summary>
    public sealed partial class PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomization
    {
        /// <summary>
        /// Role the Agent assumes when responding.<br/>
        /// Example: Salesperson
        /// </summary>
        /// <example>Salesperson</example>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Personality traits reflected in the Agent’s responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("personality")]
        public string? Personality { get; set; }

        /// <summary>
        /// List of topics the Agent should avoid discussing.<br/>
        /// Example: [Politics, Religion]
        /// </summary>
        /// <example>[Politics, Religion]</example>
        [global::Newtonsoft.Json.JsonProperty("topics_to_avoid")]
        public global::System.Collections.Generic.IList<string>? TopicsToAvoid { get; set; }

        /// <summary>
        /// Approximate maximum response length, in words.<br/>
        /// Default: 75<br/>
        /// Example: 75
        /// </summary>
        /// <example>75</example>
        [global::Newtonsoft.Json.JsonProperty("max_response_length")]
        public double? MaxResponseLength { get; set; }

        /// <summary>
        /// Defines how the Agent receives knowledge.&lt;/br&gt;<br/>
        /// - base_knowledge — Uses inline knowledge from prompt_knowledge<br/>
        /// - documents — Uses knowledge_id (RAG)<br/>
        /// (Default: documents)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledge_source")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomizationKnowledgeSourceJsonConverter))]
        public global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomizationKnowledgeSource? KnowledgeSource { get; set; }

        /// <summary>
        /// Defines the factual knowledge the Agent uses to answer questions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_knowledge")]
        public string? PromptKnowledge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomization" /> class.
        /// </summary>
        /// <param name="role">
        /// Role the Agent assumes when responding.<br/>
        /// Example: Salesperson
        /// </param>
        /// <param name="personality">
        /// Personality traits reflected in the Agent’s responses.
        /// </param>
        /// <param name="topicsToAvoid">
        /// List of topics the Agent should avoid discussing.<br/>
        /// Example: [Politics, Religion]
        /// </param>
        /// <param name="maxResponseLength">
        /// Approximate maximum response length, in words.<br/>
        /// Default: 75<br/>
        /// Example: 75
        /// </param>
        /// <param name="knowledgeSource">
        /// Defines how the Agent receives knowledge.&lt;/br&gt;<br/>
        /// - base_knowledge — Uses inline knowledge from prompt_knowledge<br/>
        /// - documents — Uses knowledge_id (RAG)<br/>
        /// (Default: documents)
        /// </param>
        /// <param name="promptKnowledge">
        /// Defines the factual knowledge the Agent uses to answer questions.
        /// </param>
        public PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomization(
            string? role,
            string? personality,
            global::System.Collections.Generic.IList<string>? topicsToAvoid,
            double? maxResponseLength,
            global::G.PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomizationKnowledgeSource? knowledgeSource,
            string? promptKnowledge)
        {
            this.Role = role;
            this.Personality = personality;
            this.TopicsToAvoid = topicsToAvoid;
            this.MaxResponseLength = maxResponseLength;
            this.KnowledgeSource = knowledgeSource;
            this.PromptKnowledge = promptKnowledge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomization" /> class.
        /// </summary>
        public PickAgentExcludeKeyofAgentUserDataOrAdvancedSettingsOrEmbedOrAssetsLlmVariant2PromptCustomization()
        {
        }
    }
}