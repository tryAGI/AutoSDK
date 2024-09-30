//HintName: G.Api.Rerankv2.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareRerankv2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            global::G.Rerankv2Request request);
        partial void PrepareRerankv2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::G.Rerankv2Request request);
        partial void ProcessRerankv2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRerankv2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Rerank<br/>
        /// This endpoint takes in a query and a list of texts and produces an ordered array with each text assigned a relevance score.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Rerankv2Response> Rerankv2Async(
            global::G.Rerankv2Request request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareRerankv2Arguments(
                httpClient: _httpClient,
                xClientName: ref xClientName,
                request: request);

            if (xClientName != default)
            {
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
            }

            var __pathBuilder = new PathBuilder(
                path: "/v2/rerank",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareRerankv2Request(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xClientName: xClientName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessRerankv2Response(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessRerankv2ResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Rerankv2Response?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

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
        public async global::System.Threading.Tasks.Task<global::G.Rerankv2Response> Rerankv2Async(
            string model,
            string query,
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.RerankDocument>> documents,
            string? xClientName = default,
            int? topN = default,
            global::System.Collections.Generic.IList<string>? rankFields = default,
            bool? returnDocuments = false,
            int? maxChunksPerDoc = 10,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.Rerankv2Request
            {
                Model = model,
                Query = query,
                Documents = documents,
                TopN = topN,
                RankFields = rankFields,
                ReturnDocuments = returnDocuments,
                MaxChunksPerDoc = maxChunksPerDoc,
            };

            return await Rerankv2Async(
                xClientName: xClientName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}