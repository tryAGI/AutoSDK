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
        [global::Newtonsoft.Json.JsonProperty("from")]
        public string? From { get; set; }

        /// <summary>
        /// The operation to be performed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PatchDocumentObjectOp Op { get; set; } = default!;

        /// <summary>
        /// A JSON-Pointer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// The value to be used within the operations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public object? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("merge")]
        public global::G.Object? Merge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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