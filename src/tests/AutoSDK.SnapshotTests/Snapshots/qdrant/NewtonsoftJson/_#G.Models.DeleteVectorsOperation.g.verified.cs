//HintName: G.Models.DeleteVectorsOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteVectorsOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_vectors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DeleteVectors DeleteVectors { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVectorsOperation" /> class.
        /// </summary>
        /// <param name="deleteVectors"></param>
        public DeleteVectorsOperation(
            global::G.DeleteVectors deleteVectors)
        {
            this.DeleteVectors = deleteVectors ?? throw new global::System.ArgumentNullException(nameof(deleteVectors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVectorsOperation" /> class.
        /// </summary>
        public DeleteVectorsOperation()
        {
        }
    }
}