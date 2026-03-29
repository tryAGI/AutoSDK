//HintName: G.Models.DocumentKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentKey
    {
        /// <summary>
        /// The document encryption key that was sent to the client when the document was uploaded to the API.<br/>
        /// Example: 0CB0054F1C132C1625B392EADDA41CB754A742822F6877173029A6C487E7F60A
        /// </summary>
        /// <example>0CB0054F1C132C1625B392EADDA41CB754A742822F6877173029A6C487E7F60A</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentKey1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentKey" /> class.
        /// </summary>
        /// <param name="documentKey1">
        /// The document encryption key that was sent to the client when the document was uploaded to the API.<br/>
        /// Example: 0CB0054F1C132C1625B392EADDA41CB754A742822F6877173029A6C487E7F60A
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentKey(
            string documentKey1)
        {
            this.DocumentKey1 = documentKey1 ?? throw new global::System.ArgumentNullException(nameof(documentKey1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentKey" /> class.
        /// </summary>
        public DocumentKey()
        {
        }
    }
}