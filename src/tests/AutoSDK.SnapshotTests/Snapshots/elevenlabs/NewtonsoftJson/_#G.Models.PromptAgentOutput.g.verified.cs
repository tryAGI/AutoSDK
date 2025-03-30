//HintName: G.Models.PromptAgentOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAgentOutput
    {
        /// <summary>
        /// The prompt for the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm")]
        public global::G.LLM? Llm { get; set; }

        /// <summary>
        /// The temperature for the LLM<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// If greater than 0, maximum number of tokens the LLM can predict<br/>
        /// Default Value: -1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// A list of tools that the agent can use over the course of the conversation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tools")]
        public global::System.Collections.Generic.IList<global::G.ToolsItem3>? Tools { get; set; }

        /// <summary>
        /// A list of IDs of tools used by the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_ids")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// A list of knowledge bases to be used by the agent
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knowledge_base")]
        public global::System.Collections.Generic.IList<global::G.KnowledgeBaseLocator>? KnowledgeBase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_llm")]
        public global::G.CustomLLM? CustomLlm { get; set; }

        /// <summary>
        /// Whether to ignore the default personality<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignore_default_personality")]
        public bool? IgnoreDefaultPersonality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rag")]
        public global::G.RagConfig? Rag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentOutput" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for the agent
        /// </param>
        /// <param name="llm"></param>
        /// <param name="temperature">
        /// The temperature for the LLM<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="maxTokens">
        /// If greater than 0, maximum number of tokens the LLM can predict<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="tools">
        /// A list of tools that the agent can use over the course of the conversation
        /// </param>
        /// <param name="toolIds">
        /// A list of IDs of tools used by the agent
        /// </param>
        /// <param name="knowledgeBase">
        /// A list of knowledge bases to be used by the agent
        /// </param>
        /// <param name="customLlm"></param>
        /// <param name="ignoreDefaultPersonality">
        /// Whether to ignore the default personality<br/>
        /// Default Value: false
        /// </param>
        /// <param name="rag"></param>
        public PromptAgentOutput(
            string? prompt,
            global::G.LLM? llm,
            double? temperature,
            int? maxTokens,
            global::System.Collections.Generic.IList<global::G.ToolsItem3>? tools,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseLocator>? knowledgeBase,
            global::G.CustomLLM? customLlm,
            bool? ignoreDefaultPersonality,
            global::G.RagConfig? rag)
        {
            this.Prompt = prompt;
            this.Llm = llm;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.Tools = tools;
            this.ToolIds = toolIds;
            this.KnowledgeBase = knowledgeBase;
            this.CustomLlm = customLlm;
            this.IgnoreDefaultPersonality = ignoreDefaultPersonality;
            this.Rag = rag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentOutput" /> class.
        /// </summary>
        public PromptAgentOutput()
        {
        }
    }
}