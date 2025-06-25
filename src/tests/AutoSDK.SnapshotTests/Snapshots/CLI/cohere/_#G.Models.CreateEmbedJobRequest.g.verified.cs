//HintName: G.Models.CreateEmbedJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEmbedJobRequest
    {
        /// <summary>
        /// ID of a [Dataset](https://docs.cohere.com/docs/datasets). The Dataset must be of type `embed-input` and must have a validation status `Validated`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// Specifies the types of embeddings you want to get back. Not required and default is None, which returns the Embed Floats response type. Can be one or more of the following types.<br/>
        /// * `"float"`: Use this when you want to get back the default float embeddings. Valid for all models.<br/>
        /// * `"int8"`: Use this when you want to get back signed int8 embeddings. Valid for v3 and newer model versions.<br/>
        /// * `"uint8"`: Use this when you want to get back unsigned int8 embeddings. Valid for v3 and newer model versions.<br/>
        /// * `"binary"`: Use this when you want to get back signed binary embeddings. Valid for v3 and newer model versions.<br/>
        /// * `"ubinary"`: Use this when you want to get back unsigned binary embeddings. Valid for v3 and newer model versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_types")]
        public global::System.Collections.Generic.IList<global::G.EmbeddingType>? EmbeddingTypes { get; set; }

        /// <summary>
        /// Specifies the type of input passed to the model. Required for embedding models v3 and higher.<br/>
        /// - `"search_document"`: Used for embeddings stored in a vector database for search use-cases.<br/>
        /// - `"search_query"`: Used for embeddings of search queries run against a vector DB to find relevant documents.<br/>
        /// - `"classification"`: Used for embeddings passed through a text classifier.<br/>
        /// - `"clustering"`: Used for the embeddings run through a clustering algorithm.<br/>
        /// - `"image"`: Used for embeddings with image input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbedInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbedInputType InputType { get; set; }

        /// <summary>
        /// ID of the embedding model.<br/>
        /// Available models and corresponding embedding dimensions:<br/>
        /// - `embed-english-v3.0` : 1024<br/>
        /// - `embed-multilingual-v3.0` : 1024<br/>
        /// - `embed-english-light-v3.0` : 384<br/>
        /// - `embed-multilingual-light-v3.0` : 384
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The name of the embed job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// One of `START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// Default Value: END
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateEmbedJobRequestTruncateJsonConverter))]
        public global::G.CreateEmbedJobRequestTruncate? Truncate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbedJobRequest" /> class.
        /// </summary>
        /// <param name="datasetId">
        /// ID of a [Dataset](https://docs.cohere.com/docs/datasets). The Dataset must be of type `embed-input` and must have a validation status `Validated`
        /// </param>
        /// <param name="embeddingTypes">
        /// Specifies the types of embeddings you want to get back. Not required and default is None, which returns the Embed Floats response type. Can be one or more of the following types.<br/>
        /// * `"float"`: Use this when you want to get back the default float embeddings. Valid for all models.<br/>
        /// * `"int8"`: Use this when you want to get back signed int8 embeddings. Valid for v3 and newer model versions.<br/>
        /// * `"uint8"`: Use this when you want to get back unsigned int8 embeddings. Valid for v3 and newer model versions.<br/>
        /// * `"binary"`: Use this when you want to get back signed binary embeddings. Valid for v3 and newer model versions.<br/>
        /// * `"ubinary"`: Use this when you want to get back unsigned binary embeddings. Valid for v3 and newer model versions.
        /// </param>
        /// <param name="inputType">
        /// Specifies the type of input passed to the model. Required for embedding models v3 and higher.<br/>
        /// - `"search_document"`: Used for embeddings stored in a vector database for search use-cases.<br/>
        /// - `"search_query"`: Used for embeddings of search queries run against a vector DB to find relevant documents.<br/>
        /// - `"classification"`: Used for embeddings passed through a text classifier.<br/>
        /// - `"clustering"`: Used for the embeddings run through a clustering algorithm.<br/>
        /// - `"image"`: Used for embeddings with image input.
        /// </param>
        /// <param name="model">
        /// ID of the embedding model.<br/>
        /// Available models and corresponding embedding dimensions:<br/>
        /// - `embed-english-v3.0` : 1024<br/>
        /// - `embed-multilingual-v3.0` : 1024<br/>
        /// - `embed-english-light-v3.0` : 384<br/>
        /// - `embed-multilingual-light-v3.0` : 384
        /// </param>
        /// <param name="name">
        /// The name of the embed job.
        /// </param>
        /// <param name="truncate">
        /// One of `START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// Default Value: END
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEmbedJobRequest(
            string datasetId,
            global::G.EmbedInputType inputType,
            string model,
            global::System.Collections.Generic.IList<global::G.EmbeddingType>? embeddingTypes,
            string? name,
            global::G.CreateEmbedJobRequestTruncate? truncate)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.InputType = inputType;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.EmbeddingTypes = embeddingTypes;
            this.Name = name;
            this.Truncate = truncate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbedJobRequest" /> class.
        /// </summary>
        public CreateEmbedJobRequest()
        {
        }
    }
}