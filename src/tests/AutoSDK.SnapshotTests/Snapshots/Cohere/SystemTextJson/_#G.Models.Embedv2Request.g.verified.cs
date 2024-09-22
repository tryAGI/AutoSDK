//HintName: G.Models.Embedv2Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Embedv2Request
    {
        /// <summary>
        /// An array of strings for the model to embed. Maximum number of texts per call is `96`. We recommend reducing the length of each text to be under `512` tokens for optimal quality.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        public global::System.Collections.Generic.IList<string>? Texts { get; set; }

        /// <summary>
        /// Defaults to embed-english-v2.0<br/>
        /// The identifier of the model. Smaller "light" models are faster, while larger models will perform better. [Custom models](/docs/training-custom-models) can also be supplied with their full ID.<br/>
        /// Available models and corresponding embedding dimensions:<br/>
        /// * `embed-english-v3.0`  1024<br/>
        /// * `embed-multilingual-v3.0`  1024<br/>
        /// * `embed-english-light-v3.0`  384<br/>
        /// * `embed-multilingual-light-v3.0`  384<br/>
        /// * `embed-english-v2.0`  4096<br/>
        /// * `embed-english-light-v2.0`  1024<br/>
        /// * `embed-multilingual-v2.0`  768<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

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
        public global::G.EmbedInputType? InputType { get; set; }

        /// <summary>
        /// Specifies the types of embeddings you want to get back. Not required and default is None, which returns the Embed Floats response type. Can be one or more of the following types.<br/>
        /// * `"float"`: Use this when you want to get back the default float embeddings. Valid for all models.<br/>
        /// * `"int8"`: Use this when you want to get back signed int8 embeddings. Valid for only v3 models.<br/>
        /// * `"uint8"`: Use this when you want to get back unsigned int8 embeddings. Valid for only v3 models.<br/>
        /// * `"binary"`: Use this when you want to get back signed binary embeddings. Valid for only v3 models.<br/>
        /// * `"ubinary"`: Use this when you want to get back unsigned binary embeddings. Valid for only v3 models.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_types")]
        public global::System.Collections.Generic.IList<global::G.EmbeddingType>? EmbeddingTypes { get; set; }

        /// <summary>
        /// One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.<br/>
        /// Default Value: END<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Embedv2RequestTruncateJsonConverter))]
        public global::G.Embedv2RequestTruncate? Truncate { get; set; } = global::G.Embedv2RequestTruncate.END;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}