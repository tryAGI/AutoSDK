//HintName: G.ISearchClient.SearchDocuments.g.cs
#nullable enable

namespace G
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// search.documents<br/>
        /// Search documents on GroundX for the most relevant information to a given query by documentId(s).<br/>
        /// The result of this query is typically used in one of two ways; result['search']['text'] can be used to provide context to a language model, facilitating RAG, or result['search']['results'] can be used to observe chunks of text which are relevant to the query, facilitating citation.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="n">
        /// Default Value: 20
        /// </param>
        /// <param name="nextToken">
        /// Example: eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9
        /// </param>
        /// <param name="verbosity"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchResponse> SearchDocumentsAsync(

            global::G.SearchDocumentsRequest request,
            int? n = default,
            string? nextToken = default,
            int? verbosity = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// search.documents<br/>
        /// Search documents on GroundX for the most relevant information to a given query by documentId(s).<br/>
        /// The result of this query is typically used in one of two ways; result['search']['text'] can be used to provide context to a language model, facilitating RAG, or result['search']['results'] can be used to observe chunks of text which are relevant to the query, facilitating citation.<br/>
        /// Interact with the "Request Body" below to explore the arguments of this function. Enter your GroundX API key to send a request directly from this web page. Select your language of choice to structure a code snippet based on your specified arguments.
        /// </summary>
        /// <param name="n">
        /// Default Value: 20
        /// </param>
        /// <param name="nextToken">
        /// Example: eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9
        /// </param>
        /// <param name="verbosity"></param>
        /// <param name="query">
        /// The search query to be used to find relevant documentation.<br/>
        /// Default Value: my search query<br/>
        /// Example: my search query
        /// </param>
        /// <param name="documentIds">
        /// An array of unique documentIds to be searched.<br/>
        /// Example: [docUUID1, docUUID2]
        /// </param>
        /// <param name="relevance">
        /// The minimum search relevance score required to include the result. By default, this is 10.0.<br/>
        /// Default Value: 10.0<br/>
        /// Example: 10.0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchResponse> SearchDocumentsAsync(
            global::System.Collections.Generic.IList<string> documentIds,
            int? n = default,
            string? nextToken = default,
            int? verbosity = default,
            string query = "my search query",
            float? relevance = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}