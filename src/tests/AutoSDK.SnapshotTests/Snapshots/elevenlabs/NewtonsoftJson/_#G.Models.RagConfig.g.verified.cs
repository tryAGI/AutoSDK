//HintName: G.Models.RagConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RagConfig
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_model")]
        public global::G.EmbeddingModelEnum? EmbeddingModel { get; set; }

        /// <summary>
        /// Maximum vector distance of retrieved chunks.<br/>
        /// Default Value: 0.6<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::Newtonsoft.Json.JsonProperty("max_vector_distance")]
        public double? MaxVectorDistance { get; set; }

        /// <summary>
        /// Maximum total length of document chunks retrieved from RAG.<br/>
        /// Default Value: 50000<br/>
        /// Example: 50000
        /// </summary>
        /// <example>50000</example>
        [global::Newtonsoft.Json.JsonProperty("max_documents_length")]
        public int? MaxDocumentsLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RagConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Default Value: false
        /// </param>
        /// <param name="embeddingModel"></param>
        /// <param name="maxVectorDistance">
        /// Maximum vector distance of retrieved chunks.<br/>
        /// Default Value: 0.6<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="maxDocumentsLength">
        /// Maximum total length of document chunks retrieved from RAG.<br/>
        /// Default Value: 50000<br/>
        /// Example: 50000
        /// </param>
        public RagConfig(
            bool? enabled,
            global::G.EmbeddingModelEnum? embeddingModel,
            double? maxVectorDistance,
            int? maxDocumentsLength)
        {
            this.Enabled = enabled;
            this.EmbeddingModel = embeddingModel;
            this.MaxVectorDistance = maxVectorDistance;
            this.MaxDocumentsLength = maxDocumentsLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RagConfig" /> class.
        /// </summary>
        public RagConfig()
        {
        }
    }
}