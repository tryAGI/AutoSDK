//HintName: G.IApi.Rerank.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Rerank<br/>
        /// This endpoint takes in a query and a list of texts and produces an ordered array with each text assigned a relevance score.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RerankResponse> RerankAsync(
            global::G.RerankRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Rerank<br/>
        /// This endpoint takes in a query and a list of texts and produces an ordered array with each text assigned a relevance score.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="model">
        /// The identifier of the model to use, one of : `rerank-english-v3.0`, `rerank-multilingual-v3.0`, `rerank-english-v2.0`, `rerank-multilingual-v2.0`
        /// </param>
        /// <param name="query">
        /// The search query
        /// </param>
        /// <param name="documents">
        /// A list of document objects or strings to rerank.<br/>
        /// If a document is provided the text fields is required and all other fields will be preserved in the response.<br/>
        /// The total max chunks (length of documents * max_chunks_per_doc) must be less than 10000.<br/>
        /// We recommend a maximum of 1,000 documents for optimal endpoint performance.
        /// </param>
        /// <param name="topN">
        /// The number of most relevant documents or indices to return, defaults to the length of the documents
        /// </param>
        /// <param name="rankFields">
        /// If a JSON object is provided, you can specify which keys you would like to have considered for reranking. The model will rerank based on order of the fields passed in (i.e. rank_fields=['title','author','text'] will rerank using the values in title, author, text  sequentially. If the length of title, author, and text exceeds the context length of the model, the chunking will not re-consider earlier fields). If not provided, the model will use the default text field for ranking.
        /// </param>
        /// <param name="returnDocuments">
        /// - If false, returns results without the doc text - the api will return a list of {index, relevance score} where index is inferred from the list passed into the request.<br/>
        /// - If true, returns results with the doc text passed in - the api will return an ordered list of {index, text, relevance score} where index + text refers to the list passed into the request.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxChunksPerDoc">
        /// The maximum number of chunks to produce internally from a document<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RerankResponse> RerankAsync(
            string query,
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.RerankDocument>> documents,
            string? xClientName = default,
            string? model = default,
            int? topN = default,
            global::System.Collections.Generic.IList<string>? rankFields = default,
            bool? returnDocuments = default,
            int? maxChunksPerDoc = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}