//HintName: G.Models.PromptCustomization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptCustomization
    {
        /// <summary>
        /// Role the Agent assumes when responding.<br/>
        /// Example: Salesperson
        /// </summary>
        /// <example>Salesperson</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Personality traits reflected in the Agent’s responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personality")]
        public string? Personality { get; set; }

        /// <summary>
        /// List of topics the Agent should avoid discussing.<br/>
        /// Example: [Politics, Religion]
        /// </summary>
        /// <example>[Politics, Religion]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics_to_avoid")]
        public global::System.Collections.Generic.IList<string>? TopicsToAvoid { get; set; }

        /// <summary>
        /// Approximate maximum response length, in words.<br/>
        /// Default: 75<br/>
        /// Example: 75
        /// </summary>
        /// <example>75</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_response_length")]
        public double? MaxResponseLength { get; set; }

        /// <summary>
        /// Defines how the Agent receives knowledge.&lt;/br&gt;<br/>
        /// - base_knowledge — Uses inline knowledge from prompt_knowledge<br/>
        /// - documents — Uses knowledge_id (RAG)<br/>
        /// (Default: documents)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PromptCustomizationKnowledgeSourceJsonConverter))]
        public global::G.PromptCustomizationKnowledgeSource? KnowledgeSource { get; set; }

        /// <summary>
        /// Defines the factual knowledge the Agent uses to answer questions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_knowledge")]
        public string? PromptKnowledge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCustomization" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCustomization(
            string? role,
            string? personality,
            global::System.Collections.Generic.IList<string>? topicsToAvoid,
            double? maxResponseLength,
            global::G.PromptCustomizationKnowledgeSource? knowledgeSource,
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
        /// Initializes a new instance of the <see cref="PromptCustomization" /> class.
        /// </summary>
        public PromptCustomization()
        {
        }
    }
}