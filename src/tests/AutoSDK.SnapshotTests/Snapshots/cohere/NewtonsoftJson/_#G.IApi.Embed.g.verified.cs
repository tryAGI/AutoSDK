//HintName: G.IApi.Embed.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Embed V1 API<br/>
        /// This endpoint returns text and image embeddings. An embedding is a list of floating point numbers that captures semantic information about the content that it represents.<br/>
        /// Embeddings can be used to create classifiers as well as empower semantic search. To learn more about embeddings, see the embedding page.<br/>
        /// If you want to learn more how to use the embedding model, have a look at the [Semantic Search Guide](https://docs.cohere.com/docs/semantic-search).
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbedResponse> EmbedAsync(
            global::G.EmbedRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Embed V1 API<br/>
        /// This endpoint returns text and image embeddings. An embedding is a list of floating point numbers that captures semantic information about the content that it represents.<br/>
        /// Embeddings can be used to create classifiers as well as empower semantic search. To learn more about embeddings, see the embedding page.<br/>
        /// If you want to learn more how to use the embedding model, have a look at the [Semantic Search Guide](https://docs.cohere.com/docs/semantic-search).
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="texts">
        /// An array of strings for the model to embed. Maximum number of texts per call is `96`.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="images">
        /// An array of image data URIs for the model to embed. Maximum number of images per call is `1`.<br/>
        /// The image must be a valid [data URI](https://developer.mozilla.org/en-US/docs/Web/URI/Schemes/data). The image must be in either `image/jpeg` or `image/png` format and has a maximum size of 5MB.<br/>
        /// Images are only supported with Embed v3.0 and newer models.
        /// </param>
        /// <param name="model">
        /// ID of one of the available [Embedding models](https://docs.cohere.com/docs/cohere-embed).<br/>
        /// Included only in requests
        /// </param>
        /// <param name="inputType">
        /// Specifies the type of input passed to the model. Required for embedding models v3 and higher.<br/>
        /// - `"search_document"`: Used for embeddings stored in a vector database for search use-cases.<br/>
        /// - `"search_query"`: Used for embeddings of search queries run against a vector DB to find relevant documents.<br/>
        /// - `"classification"`: Used for embeddings passed through a text classifier.<br/>
        /// - `"clustering"`: Used for the embeddings run through a clustering algorithm.<br/>
        /// - `"image"`: Used for embeddings with image input.
        /// </param>
        /// <param name="embeddingTypes">
        /// Specifies the types of embeddings you want to get back. Not required and default is None, which returns the Embed Floats response type. Can be one or more of the following types.<br/>
        /// * `"float"`: Use this when you want to get back the default float embeddings. Supported with all Embed models.<br/>
        /// * `"int8"`: Use this when you want to get back signed int8 embeddings. Supported with Embed v3.0 and newer Embed models.<br/>
        /// * `"uint8"`: Use this when you want to get back unsigned int8 embeddings. Supported with Embed v3.0 and newer Embed models.<br/>
        /// * `"binary"`: Use this when you want to get back signed binary embeddings. Supported with Embed v3.0 and newer Embed models.<br/>
        /// * `"ubinary"`: Use this when you want to get back unsigned binary embeddings. Supported with Embed v3.0 and newer Embed models.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="truncate">
        /// One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.<br/>
        /// Default Value: END<br/>
        /// Included only in requests
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbedResponse> EmbedAsync(
            global::System.Collections.Generic.IList<string> texts,
            string model,
            global::System.Collections.Generic.IList<global::G.EmbeddingType> embeddingTypes,
            global::G.EmbedRequestTruncate truncate,
            string? xClientName = default,
            global::System.Collections.Generic.IList<string>? images = default,
            global::G.EmbedInputType? inputType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}