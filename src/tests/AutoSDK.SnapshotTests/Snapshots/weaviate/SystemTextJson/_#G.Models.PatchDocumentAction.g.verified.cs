//HintName: G.Models.PatchDocumentAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Either a JSONPatch document as defined by RFC 6902 (from, op, path, value), or a merge document (RFC 7396).
    /// </summary>
    public sealed partial class PatchDocumentAction
    {
        /// <summary>
        /// A string containing a JSON Pointer value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// The operation to be performed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PatchDocumentActionOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PatchDocumentActionOp Op { get; set; }

        /// <summary>
        /// A JSON-Pointer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The value to be used within the operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge")]
        public global::G.Object? Merge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}