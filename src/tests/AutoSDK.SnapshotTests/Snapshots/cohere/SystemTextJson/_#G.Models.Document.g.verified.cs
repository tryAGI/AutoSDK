//HintName: G.Models.Document.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Relevant information that could be used by the model to generate a more accurate reply.<br/>
    /// The content of each document are generally short (should be under 300 words). Metadata should be used to provide additional information, both the key name and the value will be<br/>
    /// passed to the model.
    /// </summary>
    public sealed partial class Document
    {
        /// <summary>
        /// A relevant documents that the model can cite to generate a more accurate reply. Each document is a string-string dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Data { get; set; }

        /// <summary>
        /// Unique identifier for this document which will be referenced in citations. If not provided an ID will be automatically generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="data">
        /// A relevant documents that the model can cite to generate a more accurate reply. Each document is a string-string dictionary.
        /// </param>
        /// <param name="id">
        /// Unique identifier for this document which will be referenced in citations. If not provided an ID will be automatically generated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Document(
            global::System.Collections.Generic.Dictionary<string, string> data,
            string? id)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        public Document()
        {
        }
    }
}