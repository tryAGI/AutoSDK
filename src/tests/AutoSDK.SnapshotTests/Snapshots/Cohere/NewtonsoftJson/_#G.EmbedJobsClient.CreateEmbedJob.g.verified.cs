//HintName: G.EmbedJobsClient.CreateEmbedJob.g.cs

#nullable enable

namespace G
{
    public partial class EmbedJobsClient
    {
        partial void PrepareCreateEmbedJobArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            global::G.CreateEmbedJobRequest request);
        partial void PrepareCreateEmbedJobRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            global::G.CreateEmbedJobRequest request);
        partial void ProcessCreateEmbedJobResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateEmbedJobResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an Embed Job<br/>
        /// This API launches an async Embed job for a [Dataset](https://docs.cohere.com/docs/datasets) of type `embed-input`. The result of a completed embed job is new Dataset of type `embed-output`, which contains the original text entries and the corresponding embeddings.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateEmbedJobResponse> CreateEmbedJobAsync(
            global::G.CreateEmbedJobRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateEmbedJobArguments(
                httpClient: _httpClient,
                xClientName: ref xClientName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/embed-jobs",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xClientName != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("X-Client-Name", xClientName.ToString());
            }

            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateEmbedJobRequest(
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
            ProcessCreateEmbedJobResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateEmbedJobResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateEmbedJobResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create an Embed Job<br/>
        /// This API launches an async Embed job for a [Dataset](https://docs.cohere.com/docs/datasets) of type `embed-input`. The result of a completed embed job is new Dataset of type `embed-output`, which contains the original text entries and the corresponding embeddings.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="model">
        /// ID of the embedding model.<br/>
        /// Available models and corresponding embedding dimensions:<br/>
        /// - `embed-english-v3.0` : 1024<br/>
        /// - `embed-multilingual-v3.0` : 1024<br/>
        /// - `embed-english-light-v3.0` : 384<br/>
        /// - `embed-multilingual-light-v3.0` : 384
        /// </param>
        /// <param name="datasetId">
        /// ID of a [Dataset](https://docs.cohere.com/docs/datasets). The Dataset must be of type `embed-input` and must have a validation status `Validated`
        /// </param>
        /// <param name="inputType">
        /// Specifies the type of input passed to the model. Required for embedding models v3 and higher.<br/>
        /// - `"search_document"`: Used for embeddings stored in a vector database for search use-cases.<br/>
        /// - `"search_query"`: Used for embeddings of search queries run against a vector DB to find relevant documents.<br/>
        /// - `"classification"`: Used for embeddings passed through a text classifier.<br/>
        /// - `"clustering"`: Used for the embeddings run through a clustering algorithm.<br/>
        /// - `"image"`: Used for embeddings with image input.
        /// </param>
        /// <param name="name">
        /// The name of the embed job.
        /// </param>
        /// <param name="embeddingTypes">
        /// Specifies the types of embeddings you want to get back. Not required and default is None, which returns the Embed Floats response type. Can be one or more of the following types.<br/>
        /// * `"float"`: Use this when you want to get back the default float embeddings. Valid for all models.<br/>
        /// * `"int8"`: Use this when you want to get back signed int8 embeddings. Valid for only v3 models.<br/>
        /// * `"uint8"`: Use this when you want to get back unsigned int8 embeddings. Valid for only v3 models.<br/>
        /// * `"binary"`: Use this when you want to get back signed binary embeddings. Valid for only v3 models.<br/>
        /// * `"ubinary"`: Use this when you want to get back unsigned binary embeddings. Valid for only v3 models.
        /// </param>
        /// <param name="truncate">
        /// One of `START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// Default Value: END
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateEmbedJobResponse> CreateEmbedJobAsync(
            string model,
            string datasetId,
            global::G.EmbedInputType inputType,
            string? xClientName = default,
            string? name = default,
            global::System.Collections.Generic.IList<global::G.EmbeddingType>? embeddingTypes = default,
            global::G.CreateEmbedJobRequestTruncate? truncate = global::G.CreateEmbedJobRequestTruncate.END,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateEmbedJobRequest
            {
                Model = model,
                DatasetId = datasetId,
                InputType = inputType,
                Name = name,
                EmbeddingTypes = embeddingTypes,
                Truncate = truncate,
            };

            return await CreateEmbedJobAsync(
                xClientName: xClientName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}