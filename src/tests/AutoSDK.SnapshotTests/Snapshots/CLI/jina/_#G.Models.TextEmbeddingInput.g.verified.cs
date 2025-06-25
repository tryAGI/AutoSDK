﻿//HintName: G.Models.TextEmbeddingInput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The input to the API for text embedding. OpenAI compatible
    /// </summary>
    public sealed partial class TextEmbeddingInput
    {
        /// <summary>
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// - `jina-embeddings-v2-base-en`,	137M,	768<br/>
        /// - `jina-embeddings-v2-base-es`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-de`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-zh`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-code`,	137M,	768<br/>
        /// - `jina-embeddings-v3`,	570M,	1024<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// List of texts to embed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::G.ApiSchemasEmbeddingTextDoc>, global::G.ApiSchemasEmbeddingTextDoc>))]
        public global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::G.ApiSchemasEmbeddingTextDoc>, global::G.ApiSchemasEmbeddingTextDoc>? Input { get; set; }

        /// <summary>
        /// The format in which you want the embeddings to be returned.Possible value are `float`, `base64`, `binary`, `ubinary` or a list containing any of them. Defaults to `float`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.TextEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.TextEmbeddingInputEmbeddingTypeItem>>))]
        public global::G.AnyOf<global::G.TextEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.TextEmbeddingInputEmbeddingTypeItem>>? EmbeddingType { get; set; }

        /// <summary>
        /// Used to convey intended downstream application to help the model produce better embeddings. Must be one of the following values:<br/>
        /// - "retrieval.query": Specifies the given text is a query in a search or retrieval setting.<br/>
        /// - "retrieval.passage": Specifies the given text is a document in a search or retrieval setting.<br/>
        /// - "text-matching": Specifies the given text is used for Semantic Textual Similarity.<br/>
        /// - "classification": Specifies that the embedding is used for classification.<br/>
        /// - "separation": Specifies that the embedding is used for clustering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextEmbeddingInputTaskJsonConverter))]
        public global::G.TextEmbeddingInputTask? Task { get; set; }

        /// <summary>
        /// Used to specify output embedding size. If set, output embeddings will be truncated to the size specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Flag to determine if the embeddings should be normalized to have a unit L2 norm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized")]
        public bool? Normalized { get; set; }

        /// <summary>
        /// Flag to determine if late chunking is applied. If True, all the sentences in inputs will be concatenated and used as input for late chunking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("late_chunking")]
        public bool? LateChunking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextEmbeddingInput" /> class.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// - `jina-embeddings-v2-base-en`,	137M,	768<br/>
        /// - `jina-embeddings-v2-base-es`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-de`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-zh`,	161M,	768<br/>
        /// - `jina-embeddings-v2-base-code`,	137M,	768<br/>
        /// - `jina-embeddings-v3`,	570M,	1024<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).
        /// </param>
        /// <param name="input">
        /// List of texts to embed
        /// </param>
        /// <param name="embeddingType">
        /// The format in which you want the embeddings to be returned.Possible value are `float`, `base64`, `binary`, `ubinary` or a list containing any of them. Defaults to `float`
        /// </param>
        /// <param name="task">
        /// Used to convey intended downstream application to help the model produce better embeddings. Must be one of the following values:<br/>
        /// - "retrieval.query": Specifies the given text is a query in a search or retrieval setting.<br/>
        /// - "retrieval.passage": Specifies the given text is a document in a search or retrieval setting.<br/>
        /// - "text-matching": Specifies the given text is used for Semantic Textual Similarity.<br/>
        /// - "classification": Specifies that the embedding is used for classification.<br/>
        /// - "separation": Specifies that the embedding is used for clustering.
        /// </param>
        /// <param name="dimensions">
        /// Used to specify output embedding size. If set, output embeddings will be truncated to the size specified.
        /// </param>
        /// <param name="normalized">
        /// Flag to determine if the embeddings should be normalized to have a unit L2 norm
        /// </param>
        /// <param name="lateChunking">
        /// Flag to determine if late chunking is applied. If True, all the sentences in inputs will be concatenated and used as input for late chunking.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextEmbeddingInput(
            string model,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::G.ApiSchemasEmbeddingTextDoc>, global::G.ApiSchemasEmbeddingTextDoc>? input,
            global::G.AnyOf<global::G.TextEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.TextEmbeddingInputEmbeddingTypeItem>>? embeddingType,
            global::G.TextEmbeddingInputTask? task,
            int? dimensions,
            bool? normalized,
            bool? lateChunking)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.EmbeddingType = embeddingType;
            this.Task = task;
            this.Dimensions = dimensions;
            this.Normalized = normalized;
            this.LateChunking = lateChunking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextEmbeddingInput" /> class.
        /// </summary>
        public TextEmbeddingInput()
        {
        }
    }
}