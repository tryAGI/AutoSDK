//HintName: G.Models.ChatDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Relevant information that could be used by the model to generate a more accurate reply.<br/>
    /// The contents of each document are generally short (under 300 words), and are passed in the form of a<br/>
    /// dictionary of strings. Some suggested keys are "text", "author", "date". Both the key name and the value will be<br/>
    /// passed to the model.
    /// </summary>
    public sealed partial class ChatDocument
    {
        /// <summary>
        /// Unique identifier for this document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDocument" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this document.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatDocument(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDocument" /> class.
        /// </summary>
        public ChatDocument()
        {
        }
    }
}