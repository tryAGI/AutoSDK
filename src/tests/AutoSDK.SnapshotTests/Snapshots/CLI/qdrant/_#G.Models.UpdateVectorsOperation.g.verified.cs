//HintName: G.Models.UpdateVectorsOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateVectorsOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_vectors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UpdateVectors UpdateVectors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVectorsOperation" /> class.
        /// </summary>
        /// <param name="updateVectors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVectorsOperation(
            global::G.UpdateVectors updateVectors)
        {
            this.UpdateVectors = updateVectors ?? throw new global::System.ArgumentNullException(nameof(updateVectors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVectorsOperation" /> class.
        /// </summary>
        public UpdateVectorsOperation()
        {
        }
    }
}