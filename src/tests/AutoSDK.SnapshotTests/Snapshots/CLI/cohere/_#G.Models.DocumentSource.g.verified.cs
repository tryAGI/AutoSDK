//HintName: G.Models.DocumentSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A document source object containing the unique identifier of the document and the document itself.
    /// </summary>
    public sealed partial class DocumentSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public object? Document { get; set; }

        /// <summary>
        /// The unique identifier of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSource" /> class.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="id">
        /// The unique identifier of the document
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentSource(
            object? document,
            string? id)
        {
            this.Document = document;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSource" /> class.
        /// </summary>
        public DocumentSource()
        {
        }
    }
}