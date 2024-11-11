//HintName: G.Models.MixedEmbeddingInput.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The input to the API for text embedding. OpenAI compatible
    /// </summary>
    public sealed partial class MixedEmbeddingInput
    {
        /// <summary>
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2405.20204).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// List of text and images to embed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ApiSchemasEmbeddingImageDoc, global::G.ApiSchemasEmbeddingTextDoc, string>> Input { get; set; } = default!;

        /// <summary>
        /// The format in which you want the embeddings to be returned.Possible value are `float`, `base64`, `binary`, `ubinary` or a list containing any of them. Defaults to `float`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_type")]
        public global::G.AnyOf<global::G.MixedEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.MixedEmbeddingInputEmbeddingTypeItem>>? EmbeddingType { get; set; }

        /// <summary>
        /// Flag to determine if the embeddings should be normalized to have a unit L2 norm
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("normalized")]
        public bool? Normalized { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MixedEmbeddingInput" /> class.
        /// </summary>
        /// <param name="model">
        /// The identifier of the model.<br/>
        /// Available models and corresponding param size and dimension:<br/>
        /// - `jina-clip-v1`,	223M,	768<br/>
        /// For more information, please checkout our [technical blog](https://arxiv.org/abs/2405.20204).
        /// </param>
        /// <param name="input">
        /// List of text and images to embed
        /// </param>
        /// <param name="embeddingType">
        /// The format in which you want the embeddings to be returned.Possible value are `float`, `base64`, `binary`, `ubinary` or a list containing any of them. Defaults to `float`
        /// </param>
        /// <param name="normalized">
        /// Flag to determine if the embeddings should be normalized to have a unit L2 norm
        /// </param>
        public MixedEmbeddingInput(
            string model,
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ApiSchemasEmbeddingImageDoc, global::G.ApiSchemasEmbeddingTextDoc, string>> input,
            global::G.AnyOf<global::G.MixedEmbeddingInputEmbeddingType?, global::System.Collections.Generic.IList<global::G.MixedEmbeddingInputEmbeddingTypeItem>>? embeddingType,
            bool? normalized)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.EmbeddingType = embeddingType;
            this.Normalized = normalized;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MixedEmbeddingInput" /> class.
        /// </summary>
        public MixedEmbeddingInput()
        {
        }
    }
}