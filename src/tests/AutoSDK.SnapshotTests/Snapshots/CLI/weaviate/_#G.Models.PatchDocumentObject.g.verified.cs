//HintName: G.Models.PatchDocumentObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Either a JSONPatch document as defined by RFC 6902 (from, op, path, value), or a merge document (RFC 7396).
    /// </summary>
    public sealed partial class PatchDocumentObject
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PatchDocumentObjectOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PatchDocumentObjectOp Op { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDocumentObject" /> class.
        /// </summary>
        /// <param name="from">
        /// A string containing a JSON Pointer value.
        /// </param>
        /// <param name="op">
        /// The operation to be performed.
        /// </param>
        /// <param name="path">
        /// A JSON-Pointer.
        /// </param>
        /// <param name="value">
        /// The value to be used within the operations.
        /// </param>
        /// <param name="merge"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchDocumentObject(
            global::G.PatchDocumentObjectOp op,
            string path,
            string? from,
            object? value,
            global::G.Object? merge)
        {
            this.Op = op;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.From = from;
            this.Value = value;
            this.Merge = merge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDocumentObject" /> class.
        /// </summary>
        public PatchDocumentObject()
        {
        }
    }
}