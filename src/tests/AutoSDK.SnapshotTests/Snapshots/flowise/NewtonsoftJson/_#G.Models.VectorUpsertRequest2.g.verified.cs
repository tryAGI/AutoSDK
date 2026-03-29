//HintName: G.Models.VectorUpsertRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorUpsertRequest2
    {
        /// <summary>
        /// Files to be uploaded
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<byte[]> Files { get; set; } = default!;

        /// <summary>
        /// Other override configurations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelName")]
        public string? ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorUpsertRequest2" /> class.
        /// </summary>
        /// <param name="files">
        /// Files to be uploaded
        /// </param>
        /// <param name="modelName">
        /// Other override configurations
        /// </param>
        public VectorUpsertRequest2(
            global::System.Collections.Generic.IList<byte[]> files,
            string? modelName)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.ModelName = modelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorUpsertRequest2" /> class.
        /// </summary>
        public VectorUpsertRequest2()
        {
        }
    }
}