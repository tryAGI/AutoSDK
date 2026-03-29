//HintName: G.Models.Document.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// WARN: Work-in-progress, unimplemented<br/>
    /// Text document for embedding. Requires inference infrastructure, unimplemented.
    /// </summary>
    public sealed partial class Document
    {
        /// <summary>
        /// Text of the document. This field will be used as input for the embedding model.<br/>
        /// Example: This is a document text
        /// </summary>
        /// <example>This is a document text</example>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Name of the model used to generate the vector. List of available models depends on a provider.<br/>
        /// Example: jinaai/jina-embeddings-v2-base-en
        /// </summary>
        /// <example>jinaai/jina-embeddings-v2-base-en</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Additional options for the model, will be passed to the inference service as-is. See model cards for available options.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.DocumentOptions2? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="text">
        /// Text of the document. This field will be used as input for the embedding model.<br/>
        /// Example: This is a document text
        /// </param>
        /// <param name="model">
        /// Name of the model used to generate the vector. List of available models depends on a provider.<br/>
        /// Example: jinaai/jina-embeddings-v2-base-en
        /// </param>
        /// <param name="options">
        /// Additional options for the model, will be passed to the inference service as-is. See model cards for available options.
        /// </param>
        public Document(
            string text,
            string model,
            global::G.DocumentOptions2? options)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        public Document()
        {
        }
    }
}