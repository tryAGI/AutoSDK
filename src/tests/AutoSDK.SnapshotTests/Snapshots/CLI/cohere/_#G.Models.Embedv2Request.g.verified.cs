﻿//HintName: G.Models.Embedv2Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Embedv2Request
    {
        /// <summary>
        /// Specifies the types of embeddings you want to get back. Can be one or more of the following types.<br/>
        /// * `"float"`: Use this when you want to get back the default float embeddings. Supported with all Embed models.<br/>
        /// * `"int8"`: Use this when you want to get back signed int8 embeddings. Supported with Embed v3.0 and newer Embed models.<br/>
        /// * `"uint8"`: Use this when you want to get back unsigned int8 embeddings. Supported with Embed v3.0 and newer Embed models.<br/>
        /// * `"binary"`: Use this when you want to get back signed binary embeddings. Supported with Embed v3.0 and newer Embed models.<br/>
        /// * `"ubinary"`: Use this when you want to get back unsigned binary embeddings. Supported with Embed v3.0 and newer Embed models.<br/>
        /// Default Value: [float]<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_types")]
        public global::System.Collections.Generic.IList<global::G.EmbeddingType>? EmbeddingTypes { get; set; }

        /// <summary>
        /// An array of image data URIs for the model to embed. Maximum number of images per call is `1`.<br/>
        /// The image must be a valid [data URI](https://developer.mozilla.org/en-US/docs/Web/URI/Schemes/data). The image must be in either `image/jpeg` or `image/png` format and has a maximum size of 5MB.<br/>
        /// Image embeddings are supported with Embed v3.0 and newer models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<string>? Images { get; set; }

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
        /// An array of inputs for the model to embed. Maximum number of inputs per call is `96`. An input can contain a mix of text and image components.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::System.Collections.Generic.IList<global::G.EmbedInput>? Inputs { get; set; }

        /// <summary>
        /// The maximum number of tokens to embed per input. If the input text is longer than this, it will be truncated according to the `truncate` parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// ID of one of the available [Embedding models](https://docs.cohere.com/docs/cohere-embed).<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The number of dimensions of the output embedding. This is only available for `embed-v4` and newer models.<br/>
        /// Possible values are `256`, `512`, `1024`, and `1536`. The default is `1536`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dimension")]
        public int? OutputDimension { get; set; }

        /// <summary>
        /// An array of strings for the model to embed. Maximum number of texts per call is `96`.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        public global::System.Collections.Generic.IList<string>? Texts { get; set; }

        /// <summary>
        /// One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.<br/>
        /// Default Value: END<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Embedv2RequestTruncateJsonConverter))]
        public global::G.Embedv2RequestTruncate? Truncate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Embedv2Request" /> class.
        /// </summary>
        /// <param name="embeddingTypes">
        /// Specifies the types of embeddings you want to get back. Can be one or more of the following types.<br/>
        /// * `"float"`: Use this when you want to get back the default float embeddings. Supported with all Embed models.<br/>
        /// * `"int8"`: Use this when you want to get back signed int8 embeddings. Supported with Embed v3.0 and newer Embed models.<br/>
        /// * `"uint8"`: Use this when you want to get back unsigned int8 embeddings. Supported with Embed v3.0 and newer Embed models.<br/>
        /// * `"binary"`: Use this when you want to get back signed binary embeddings. Supported with Embed v3.0 and newer Embed models.<br/>
        /// * `"ubinary"`: Use this when you want to get back unsigned binary embeddings. Supported with Embed v3.0 and newer Embed models.<br/>
        /// Default Value: [float]<br/>
        /// Included only in requests
        /// </param>
        /// <param name="images">
        /// An array of image data URIs for the model to embed. Maximum number of images per call is `1`.<br/>
        /// The image must be a valid [data URI](https://developer.mozilla.org/en-US/docs/Web/URI/Schemes/data). The image must be in either `image/jpeg` or `image/png` format and has a maximum size of 5MB.<br/>
        /// Image embeddings are supported with Embed v3.0 and newer models.
        /// </param>
        /// <param name="inputType">
        /// Specifies the type of input passed to the model. Required for embedding models v3 and higher.<br/>
        /// - `"search_document"`: Used for embeddings stored in a vector database for search use-cases.<br/>
        /// - `"search_query"`: Used for embeddings of search queries run against a vector DB to find relevant documents.<br/>
        /// - `"classification"`: Used for embeddings passed through a text classifier.<br/>
        /// - `"clustering"`: Used for the embeddings run through a clustering algorithm.<br/>
        /// - `"image"`: Used for embeddings with image input.
        /// </param>
        /// <param name="inputs">
        /// An array of inputs for the model to embed. Maximum number of inputs per call is `96`. An input can contain a mix of text and image components.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to embed per input. If the input text is longer than this, it will be truncated according to the `truncate` parameter.
        /// </param>
        /// <param name="model">
        /// ID of one of the available [Embedding models](https://docs.cohere.com/docs/cohere-embed).<br/>
        /// Included only in requests
        /// </param>
        /// <param name="outputDimension">
        /// The number of dimensions of the output embedding. This is only available for `embed-v4` and newer models.<br/>
        /// Possible values are `256`, `512`, `1024`, and `1536`. The default is `1536`.
        /// </param>
        /// <param name="texts">
        /// An array of strings for the model to embed. Maximum number of texts per call is `96`.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="truncate">
        /// One of `NONE|START|END` to specify how the API will handle inputs longer than the maximum token length.<br/>
        /// Passing `START` will discard the start of the input. `END` will discard the end of the input. In both cases, input is discarded until the remaining input is exactly the maximum input token length for the model.<br/>
        /// If `NONE` is selected, when the input exceeds the maximum input token length an error will be returned.<br/>
        /// Default Value: END<br/>
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Embedv2Request(
            global::G.EmbedInputType inputType,
            global::System.Collections.Generic.IList<global::G.EmbeddingType>? embeddingTypes,
            global::System.Collections.Generic.IList<string>? images,
            global::System.Collections.Generic.IList<global::G.EmbedInput>? inputs,
            int? maxTokens,
            string? model,
            int? outputDimension,
            global::System.Collections.Generic.IList<string>? texts,
            global::G.Embedv2RequestTruncate? truncate)
        {
            this.InputType = inputType;
            this.EmbeddingTypes = embeddingTypes;
            this.Images = images;
            this.Inputs = inputs;
            this.MaxTokens = maxTokens;
            this.Model = model;
            this.OutputDimension = outputDimension;
            this.Texts = texts;
            this.Truncate = truncate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Embedv2Request" /> class.
        /// </summary>
        public Embedv2Request()
        {
        }
    }
}