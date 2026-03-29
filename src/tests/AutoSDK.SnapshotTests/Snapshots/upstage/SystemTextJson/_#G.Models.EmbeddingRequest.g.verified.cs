//HintName: G.Models.EmbeddingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingRequest
    {
        /// <summary>
        /// The model to use for generating embeddings.<br/>
        /// Available models: solar-embedding-1-large, solar-embedding-1-large-passage,<br/>
        /// solar-embedding-1-large-query<br/>
        /// Example: solar-embedding-1-large
        /// </summary>
        /// <example>solar-embedding-1-large</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Input text to embed. Can be a string or array of strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<string, global::System.Collections.Generic.IList<string>> Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for generating embeddings.<br/>
        /// Available models: solar-embedding-1-large, solar-embedding-1-large-passage,<br/>
        /// solar-embedding-1-large-query<br/>
        /// Example: solar-embedding-1-large
        /// </param>
        /// <param name="input">
        /// Input text to embed. Can be a string or array of strings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingRequest(
            string model,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> input)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingRequest" /> class.
        /// </summary>
        public EmbeddingRequest()
        {
        }
    }
}