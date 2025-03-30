//HintName: G.Models.UpdateDocumentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for updating the document. For PUT requests, the request body metadata replaces the existing<br/>
    /// metadata. For PATCH requests, the request body metadata is merged with the existing metadata, <br/>
    /// adding or modifying only the specified fields.
    /// </summary>
    public sealed partial class UpdateDocumentRequest
    {
        /// <summary>
        /// The metadata for a document as an arbitrary object. Properties of this object<br/>
        /// can be used by document level filter attributes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// The metadata for a document as an arbitrary object. Properties of this object<br/>
        /// can be used by document level filter attributes.
        /// </param>
        public UpdateDocumentRequest(
            object? metadata)
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentRequest" /> class.
        /// </summary>
        public UpdateDocumentRequest()
        {
        }
    }
}