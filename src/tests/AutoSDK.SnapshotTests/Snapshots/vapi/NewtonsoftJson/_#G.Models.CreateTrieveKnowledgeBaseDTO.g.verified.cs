//HintName: G.Models.CreateTrieveKnowledgeBaseDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTrieveKnowledgeBaseDTO
    {
        /// <summary>
        /// This knowledge base is provided by Trieve.<br/>
        /// To learn more about Trieve, visit https://trieve.ai.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateTrieveKnowledgeBaseDTOProviderJsonConverter))]
        public global::G.CreateTrieveKnowledgeBaseDTOProvider Provider { get; set; }

        /// <summary>
        /// This is the name of the knowledge base.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the searching plan used when searching for relevant chunks from the vector store.<br/>
        /// You should configure this if you're running into these issues:<br/>
        /// - Too much unnecessary context is being fed as knowledge base context.<br/>
        /// - Not enough relevant context is being fed as knowledge base context.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("searchPlan")]
        public global::G.TrieveKnowledgeBaseSearchPlan? SearchPlan { get; set; }

        /// <summary>
        /// This is the plan if you want us to create/import a new vector store using Trieve.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createPlan")]
        public global::G.TrieveKnowledgeBaseImport? CreatePlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrieveKnowledgeBaseDTO" /> class.
        /// </summary>
        /// <param name="provider">
        /// This knowledge base is provided by Trieve.<br/>
        /// To learn more about Trieve, visit https://trieve.ai.
        /// </param>
        /// <param name="name">
        /// This is the name of the knowledge base.
        /// </param>
        /// <param name="searchPlan">
        /// This is the searching plan used when searching for relevant chunks from the vector store.<br/>
        /// You should configure this if you're running into these issues:<br/>
        /// - Too much unnecessary context is being fed as knowledge base context.<br/>
        /// - Not enough relevant context is being fed as knowledge base context.
        /// </param>
        /// <param name="createPlan">
        /// This is the plan if you want us to create/import a new vector store using Trieve.
        /// </param>
        public CreateTrieveKnowledgeBaseDTO(
            global::G.CreateTrieveKnowledgeBaseDTOProvider provider,
            string? name,
            global::G.TrieveKnowledgeBaseSearchPlan? searchPlan,
            global::G.TrieveKnowledgeBaseImport? createPlan)
        {
            this.Provider = provider;
            this.Name = name;
            this.SearchPlan = searchPlan;
            this.CreatePlan = createPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrieveKnowledgeBaseDTO" /> class.
        /// </summary>
        public CreateTrieveKnowledgeBaseDTO()
        {
        }
    }
}