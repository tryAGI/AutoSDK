//HintName: G.Models.EmbeddingRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingRequest
    {
        /// <summary>
        /// The format to return the embeddings in.<br/>
        /// Default Value: float
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoding_format")]
        public string? EncodingFormat { get; set; }

        /// <summary>
        /// Text to embed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; } = default!;

        /// <summary>
        /// ID of the model to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingRequest" /> class.
        /// </summary>
        /// <param name="encodingFormat">
        /// The format to return the embeddings in.<br/>
        /// Default Value: float
        /// </param>
        /// <param name="input">
        /// Text to embed.
        /// </param>
        /// <param name="model">
        /// ID of the model to use.
        /// </param>
        public EmbeddingRequest(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> input,
            string model,
            string? encodingFormat)
        {
            this.Input = input;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.EncodingFormat = encodingFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingRequest" /> class.
        /// </summary>
        public EmbeddingRequest()
        {
        }
    }
}