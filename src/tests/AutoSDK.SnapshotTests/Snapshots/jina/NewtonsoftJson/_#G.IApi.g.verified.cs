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
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


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