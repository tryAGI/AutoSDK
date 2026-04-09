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
        [global::Newtonsoft.Json.JsonProperty("op", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JsonPatchOperationOpJsonConverter))]
        public global::G.JsonPatchOperationOp Op { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public object? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from")]
        public string? From { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonPatchOperation" /> class.
        /// </summary>
        /// <param name="op"></param>
        /// <param name="path"></param>
        /// <param name="value"></param>
        /// <param name="from"></param>
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