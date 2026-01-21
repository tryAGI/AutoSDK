//HintName: G.IEmbedJobsClient.CreateEmbedJob.g.cs
#nullable enable

namespace G
{
    public partial interface IEmbedJobsClient
    {
        /// <summary>
        /// Create an Embed Job<br/>
        /// This API launches an async Embed job for a [Dataset](https://docs.cohere.com/docs/datasets) of type `embed-input`. The result of a completed embed job is new Dataset of type `embed-output`, which contains the original text entries and the corresponding embeddings.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateEmbedJobResponse> CreateEmbedJobAsync(
            global::G.CreateEmbedJobRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

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
        /// * `"int8"`: Use this when you want to get back signed int8 embeddings. Valid for v3 and newer model versions.<br/>
        /// * `"uint8"`: Use this when you want to get back unsigned int8 embeddings. Valid for v3 and newer model versions.<br/>
        /// * `"binary"`: Use this when you want to get back signed binary embeddings. Valid for v3 and newer model versions.<br/>
        /// * `"ubinary"`: Use this when you want to get back unsigned binary embeddings. Valid for v3 and newer model versions.
        /// </param>
        /// <param name="truncate">
        /// One of `START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// Default Value: END
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateEmbedJobResponse> CreateEmbedJobAsync(
            string model,
            string datasetId,
            global::G.EmbedInputType inputType,
            string? xClientName = default,
            string? name = default,
            global::System.Collections.Generic.IList<global::G.EmbeddingType>? embeddingTypes = default,
            global::G.CreateEmbedJobRequestTruncate? truncate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}