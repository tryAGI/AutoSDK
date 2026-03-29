//HintName: G.Models.Document.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Document
    {
        /// <summary>
        /// Example: This is the content of the page.
        /// </summary>
        /// <example>This is the content of the page.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageContent")]
        public string? PageContent { get; set; }

        /// <summary>
        /// Example: {"author":"John Doe","date":"2024-08-24"}
        /// </summary>
        /// <example>{"author":"John Doe","date":"2024-08-24"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="pageContent">
        /// Example: This is the content of the page.
        /// </param>
        /// <param name="metadata">
        /// Example: {"author":"John Doe","date":"2024-08-24"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Document(
            string? pageContent,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.PageContent = pageContent;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        public Document()
        {
        }
    }
}