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
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// Other override configurations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelName")]
        public string? ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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