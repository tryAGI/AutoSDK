//HintName: G.Models.ModelEmbeddingOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output of the embedding service
    /// </summary>
    public sealed partial class ModelEmbeddingOutput
    {
        /// <summary>
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-embedding-t-en-v1`,	14m,	312<br/>
        /// - `jina-embedding-s-en-v1`,	35m,	512 (default)<br/>
        /// - `jina-embedding-b-en-v1`,	110m,	768<br/>
        /// - `jina-embedding-l-en-v1`,	330,	1024<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// A list of Embedding Objects returned by the embedding service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Data { get; set; }

        /// <summary>
        /// Total usage of the request. Sums up the usage from each individual input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApiSchemasEmbeddingUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelEmbeddingOutput" /> class.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-embedding-t-en-v1`,	14m,	312<br/>
        /// - `jina-embedding-s-en-v1`,	35m,	512 (default)<br/>
        /// - `jina-embedding-b-en-v1`,	110m,	768<br/>
        /// - `jina-embedding-l-en-v1`,	330,	1024<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2307.11224).
        /// </param>
        /// <param name="object">
        /// Default Value: list
        /// </param>
        /// <param name="data">
        /// A list of Embedding Objects returned by the embedding service
        /// </param>
        /// <param name="usage">
        /// Total usage of the request. Sums up the usage from each individual input
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelEmbeddingOutput(
            string model,
            global::System.Collections.Generic.IList<object> data,
            global::G.ApiSchemasEmbeddingUsage usage,
            string? @object)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelEmbeddingOutput" /> class.
        /// </summary>
        public ModelEmbeddingOutput()
        {
        }
    }
}