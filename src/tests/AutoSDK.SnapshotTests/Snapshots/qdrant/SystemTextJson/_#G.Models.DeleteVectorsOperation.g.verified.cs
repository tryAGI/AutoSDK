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
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_vectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DeleteVectors DeleteVectors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVectorsOperation" /> class.
        /// </summary>
        /// <param name="deleteVectors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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