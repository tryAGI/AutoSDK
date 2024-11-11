//HintName: G.Models.Rerankv2ResponseResultDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If `return_documents` is set as `false` this will return none, if `true` it will return the documents passed in
    /// </summary>
    public sealed partial class Rerankv2ResponseResultDocument
    {
        /// <summary>
        /// The text of the document to rerank
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Rerankv2ResponseResultDocument" /> class.
        /// </summary>
        /// <param name="text">
        /// The text of the document to rerank
        /// </param>
        public Rerankv2ResponseResultDocument(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rerankv2ResponseResultDocument" /> class.
        /// </summary>
        public Rerankv2ResponseResultDocument()
        {
        }
    }
}