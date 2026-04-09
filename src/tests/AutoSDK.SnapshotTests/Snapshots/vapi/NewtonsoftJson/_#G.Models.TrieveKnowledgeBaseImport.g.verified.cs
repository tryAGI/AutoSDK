//HintName: G.Models.TrieveKnowledgeBaseImport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrieveKnowledgeBaseImport
    {
        /// <summary>
        /// This is to import an existing dataset from Trieve.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TrieveKnowledgeBaseImportTypeJsonConverter))]
        public global::G.TrieveKnowledgeBaseImportType Type { get; set; }

        /// <summary>
        /// This is the `datasetId` of the dataset on your Trieve account.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("providerId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrieveKnowledgeBaseImport" /> class.
        /// </summary>
        /// <param name="providerId">
        /// This is the `datasetId` of the dataset on your Trieve account.
        /// </param>
        /// <param name="type">
        /// This is to import an existing dataset from Trieve.
        /// </param>
        public TrieveKnowledgeBaseImport(
            string providerId,
            global::G.TrieveKnowledgeBaseImportType type)
        {
            this.Type = type;
            this.ProviderId = providerId ?? throw new global::System.ArgumentNullException(nameof(providerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrieveKnowledgeBaseImport" /> class.
        /// </summary>
        public TrieveKnowledgeBaseImport()
        {
        }
    }
}