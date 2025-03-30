//HintName: G.Models.PromptEvaluationCriteria.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An evaluation using the transcript and a prompt for a yes/no achieved answer
    /// </summary>
    public sealed partial class PromptEvaluationCriteria
    {
        /// <summary>
        /// The unique identifier for the evaluation criteria
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of evaluation criteria<br/>
        /// Default Value: prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PromptEvaluationCriteriaType? Type { get; set; }

        /// <summary>
        /// The prompt that the agent should use to evaluate the conversation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_goal_prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConversationGoalPrompt { get; set; } = default!;

        /// <summary>
        /// When evaluating the prompt, should the agent's knowledge base be used.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_knowledge_base")]
        public bool? UseKnowledgeBase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptEvaluationCriteria" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the evaluation criteria
        /// </param>
        /// <param name="name"></param>
        /// <param name="type">
        /// The type of evaluation criteria<br/>
        /// Default Value: prompt
        /// </param>
        /// <param name="conversationGoalPrompt">
        /// The prompt that the agent should use to evaluate the conversation
        /// </param>
        /// <param name="useKnowledgeBase">
        /// When evaluating the prompt, should the agent's knowledge base be used.<br/>
        /// Default Value: false
        /// </param>
        public PromptEvaluationCriteria(
            string id,
            string conversationGoalPrompt,
            string? name,
            global::G.PromptEvaluationCriteriaType? type,
            bool? useKnowledgeBase)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ConversationGoalPrompt = conversationGoalPrompt ?? throw new global::System.ArgumentNullException(nameof(conversationGoalPrompt));
            this.Name = name;
            this.Type = type;
            this.UseKnowledgeBase = useKnowledgeBase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptEvaluationCriteria" /> class.
        /// </summary>
        public PromptEvaluationCriteria()
        {
        }
    }
}