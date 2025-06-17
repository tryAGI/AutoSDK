//HintName: G.Models.RAGDocumentIndexResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RAGDocumentIndexResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingModelEnum Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RAGIndexStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress_percentage", Required = global::Newtonsoft.Json.Required.Always)]
        public double ProgressPercentage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_model_index_usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RAGDocumentIndexUsage DocumentModelIndexUsage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGDocumentIndexResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <param name="status"></param>
        /// <param name="progressPercentage"></param>
        /// <param name="documentModelIndexUsage"></param>
        public RAGDocumentIndexResponseModel(
            string id,
            global::G.EmbeddingModelEnum model,
            global::G.RAGIndexStatus status,
            double progressPercentage,
            global::G.RAGDocumentIndexUsage documentModelIndexUsage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model;
            this.Status = status;
            this.ProgressPercentage = progressPercentage;
            this.DocumentModelIndexUsage = documentModelIndexUsage ?? throw new global::System.ArgumentNullException(nameof(documentModelIndexUsage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAGDocumentIndexResponseModel" /> class.
        /// </summary>
        public RAGDocumentIndexResponseModel()
        {
        }
    }
}