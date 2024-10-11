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
        [global::Newtonsoft.Json.JsonProperty("from")]
        public string? From { get; set; }

        /// <summary>
        /// The operation to be performed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PatchDocumentActionOp Op { get; set; } = default!;

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
    }
}