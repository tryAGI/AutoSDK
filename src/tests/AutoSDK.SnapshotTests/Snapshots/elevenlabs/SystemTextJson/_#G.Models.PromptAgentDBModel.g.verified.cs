//HintName: G.Models.PromptAgentDBModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"knowledge_base":[],"llm":"gemini-2.0-flash-001","max_tokens":-1,"prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","temperature":0,"tool_ids":[],"tools":[]}
    /// </summary>
    public sealed partial class PromptAgentDBModel
    {
        /// <summary>
        /// The prompt for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The LLM to query with the prompt and the chat history<br/>
        /// Default Value: gemini-2.0-flash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LLMJsonConverter))]
        public global::G.LLM? Llm { get; set; }

        /// <summary>
        /// The temperature for the LLM<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// If greater than 0, maximum number of tokens the LLM can predict<br/>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// A list of tools that the agent can use over the course of the conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::G.ToolsItem4>? Tools { get; set; }

        /// <summary>
        /// A list of IDs of tools used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_ids")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// A list of MCP server ids to be used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_ids")]
        public global::System.Collections.Generic.IList<string>? McpServerIds { get; set; }

        /// <summary>
        /// A list of Native MCP server ids to be used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_mcp_server_ids")]
        public global::System.Collections.Generic.IList<string>? NativeMcpServerIds { get; set; }

        /// <summary>
        /// A list of knowledge bases to be used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base")]
        public global::System.Collections.Generic.IList<global::G.KnowledgeBaseLocator>? KnowledgeBase { get; set; }

        /// <summary>
        /// Definition for a custom LLM if LLM field is set to 'CUSTOM_LLM'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm")]
        public global::G.CustomLLM? CustomLlm { get; set; }

        /// <summary>
        /// Whether to ignore the default personality<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_default_personality")]
        public bool? IgnoreDefaultPersonality { get; set; }

        /// <summary>
        /// Configuration for RAG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag")]
        public global::G.RagConfig? Rag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_document_ids")]
        public global::System.Collections.Generic.IList<string>? KnowledgeBaseDocumentIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("built_in_tools")]
        public global::G.BuiltInTools? BuiltInTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentDBModel" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for the agent
        /// </param>
        /// <param name="llm">
        /// The LLM to query with the prompt and the chat history<br/>
        /// Default Value: gemini-2.0-flash
        /// </param>
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
        /// <param name="mcpServerIds">
        /// A list of MCP server ids to be used by the agent
        /// </param>
        /// <param name="nativeMcpServerIds">
        /// A list of Native MCP server ids to be used by the agent
        /// </param>
        /// <param name="knowledgeBase">
        /// A list of knowledge bases to be used by the agent
        /// </param>
        /// <param name="customLlm">
        /// Definition for a custom LLM if LLM field is set to 'CUSTOM_LLM'
        /// </param>
        /// <param name="ignoreDefaultPersonality">
        /// Whether to ignore the default personality<br/>
        /// Default Value: false
        /// </param>
        /// <param name="rag">
        /// Configuration for RAG
        /// </param>
        /// <param name="knowledgeBaseDocumentIds"></param>
        /// <param name="builtInTools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAgentDBModel(
            string? prompt,
            global::G.LLM? llm,
            double? temperature,
            int? maxTokens,
            global::System.Collections.Generic.IList<global::G.ToolsItem4>? tools,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::System.Collections.Generic.IList<string>? mcpServerIds,
            global::System.Collections.Generic.IList<string>? nativeMcpServerIds,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseLocator>? knowledgeBase,
            global::G.CustomLLM? customLlm,
            bool? ignoreDefaultPersonality,
            global::G.RagConfig? rag,
            global::System.Collections.Generic.IList<string>? knowledgeBaseDocumentIds,
            global::G.BuiltInTools? builtInTools)
        {
            this.Prompt = prompt;
            this.Llm = llm;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.Tools = tools;
            this.ToolIds = toolIds;
            this.McpServerIds = mcpServerIds;
            this.NativeMcpServerIds = nativeMcpServerIds;
            this.KnowledgeBase = knowledgeBase;
            this.CustomLlm = customLlm;
            this.IgnoreDefaultPersonality = ignoreDefaultPersonality;
            this.Rag = rag;
            this.KnowledgeBaseDocumentIds = knowledgeBaseDocumentIds;
            this.BuiltInTools = builtInTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentDBModel" /> class.
        /// </summary>
        public PromptAgentDBModel()
        {
        }
    }
}