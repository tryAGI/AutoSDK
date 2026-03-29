//HintName: G.Models.TrieveKnowledgeBase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrieveKnowledgeBase
    {
        /// <summary>
        /// This knowledge base is provided by Trieve.<br/>
        /// To learn more about Trieve, visit https://trieve.ai.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TrieveKnowledgeBaseProviderJsonConverter))]
        public global::G.TrieveKnowledgeBaseProvider Provider { get; set; }

        /// <summary>
        /// This is the name of the knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the searching plan used when searching for relevant chunks from the vector store.<br/>
        /// You should configure this if you're running into these issues:<br/>
        /// - Too much unnecessary context is being fed as knowledge base context.<br/>
        /// - Not enough relevant context is being fed as knowledge base context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchPlan")]
        public global::G.TrieveKnowledgeBaseSearchPlan? SearchPlan { get; set; }

        /// <summary>
        /// This is the plan if you want us to create/import a new vector store using Trieve.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createPlan")]
        public global::G.TrieveKnowledgeBaseImport? CreatePlan { get; set; }

        /// <summary>
        /// This is the id of the knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the org id of the knowledge base.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrieveKnowledgeBase" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the id of the knowledge base.
        /// </param>
        /// <param name="orgId">
        /// This is the org id of the knowledge base.
        /// </param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrieveKnowledgeBase(
            string id,
            string orgId,
            global::G.TrieveKnowledgeBaseProvider provider,
            string? name,
            global::G.TrieveKnowledgeBaseSearchPlan? searchPlan,
            global::G.TrieveKnowledgeBaseImport? createPlan)
        {
            this.Provider = provider;
            this.Name = name;
            this.SearchPlan = searchPlan;
            this.CreatePlan = createPlan;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrieveKnowledgeBase" /> class.
        /// </summary>
        public TrieveKnowledgeBase()
        {
        }
    }
}