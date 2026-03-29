//HintName: G.Models.NamedSparseVector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sparse vector data with name
    /// </summary>
    public sealed partial class NamedSparseVector
    {
        /// <summary>
        /// Name of vector data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Sparse vector structure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SparseVector Vector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedSparseVector" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of vector data
        /// </param>
        /// <param name="vector">
        /// Sparse vector structure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamedSparseVector(
            string name,
            global::G.SparseVector vector)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Vector = vector ?? throw new global::System.ArgumentNullException(nameof(vector));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedSparseVector" /> class.
        /// </summary>
        public NamedSparseVector()
        {
        }
    }
}