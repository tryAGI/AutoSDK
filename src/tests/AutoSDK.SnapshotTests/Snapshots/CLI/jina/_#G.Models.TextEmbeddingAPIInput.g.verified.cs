﻿//HintName: G.Models.TextEmbeddingAPIInput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The input to the API for text embedding. OpenAI compatible
    /// </summary>
    public sealed partial class TextEmbeddingAPIInput
    {
        /// <summary>
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-colbert-v1-en`,	137
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// List of texts to embed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::G.ApiSchemasEmbeddingTextDoc>, global::G.ApiSchemasEmbeddingTextDoc>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::G.ApiSchemasEmbeddingTextDoc>, global::G.ApiSchemasEmbeddingTextDoc> Input { get; set; }

        /// <summary>
        /// Type of the embedding to compute, query or document<br/>
        /// Default Value: document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextEmbeddingAPIInputInputTypeJsonConverter))]
        public global::G.TextEmbeddingAPIInputInputType? InputType { get; set; }

        /// <summary>
        /// The format in which you want the embeddings to be returned.Possible value are `float`, `base64`, `binary`, `ubinary` or a list containing any of them. Defaults to `float`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.TextEmbeddingAPIInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.TextEmbeddingAPIInputEmbeddingTypeItem>>))]
        public global::G.AnyOf<global::G.TextEmbeddingAPIInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.TextEmbeddingAPIInputEmbeddingTypeItem>>? EmbeddingType { get; set; }

        /// <summary>
        /// Dimensions of the vectors to be returned. Only valid for v2 colbert models. Defaults to 128
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextEmbeddingAPIInput" /> class.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-colbert-v1-en`,	137
        /// </param>
        /// <param name="input">
        /// List of texts to embed
        /// </param>
        /// <param name="inputType">
        /// Type of the embedding to compute, query or document<br/>
        /// Default Value: document
        /// </param>
        /// <param name="embeddingType">
        /// The format in which you want the embeddings to be returned.Possible value are `float`, `base64`, `binary`, `ubinary` or a list containing any of them. Defaults to `float`
        /// </param>
        /// <param name="dimensions">
        /// Dimensions of the vectors to be returned. Only valid for v2 colbert models. Defaults to 128
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextEmbeddingAPIInput(
            string model,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, global::System.Collections.Generic.IList<global::G.ApiSchemasEmbeddingTextDoc>, global::G.ApiSchemasEmbeddingTextDoc> input,
            global::G.TextEmbeddingAPIInputInputType? inputType,
            global::G.AnyOf<global::G.TextEmbeddingAPIInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.TextEmbeddingAPIInputEmbeddingTypeItem>>? embeddingType,
            int? dimensions)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.InputType = inputType;
            this.EmbeddingType = embeddingType;
            this.Dimensions = dimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextEmbeddingAPIInput" /> class.
        /// </summary>
        public TextEmbeddingAPIInput()
        {
        }
    }
}