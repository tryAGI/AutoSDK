//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the UniversalAPI to access all the Jina embedding models<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings { get; }

        /// <summary>
        /// 
        /// </summary>
        public BulkEmbeddingsClient BulkEmbeddings { get; }

        /// <summary>
        /// 
        /// </summary>
        public RerankClient Rerank { get; }

        /// <summary>
        /// 
        /// </summary>
        public ClassificationClient Classification { get; }

        /// <summary>
        /// 
        /// </summary>
        public MultiVectorClient MultiVector { get; }

    }
}