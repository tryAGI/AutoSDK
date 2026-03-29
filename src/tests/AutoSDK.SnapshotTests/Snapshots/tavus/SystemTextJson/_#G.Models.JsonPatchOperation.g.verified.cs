//HintName: G.Models.JsonPatchOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonPatchOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JsonPatchOperationOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JsonPatchOperationOp Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonPatchOperation" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="path"></param>
        /// <param name="value"></param>
        /// <param name="from"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonPatchOperation(
            global::G.JsonPatchOperationOp op,
            string path,
            object? value,
            string? from)
        {
            this.Op = op;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Value = value;
            this.From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonPatchOperation" /> class.
        /// </summary>
        public JsonPatchOperation()
        {
        }
    }
}