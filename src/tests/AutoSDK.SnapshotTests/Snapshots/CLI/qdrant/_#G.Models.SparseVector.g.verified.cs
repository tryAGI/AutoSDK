//HintName: G.Models.SparseVector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sparse vector structure
    /// </summary>
    public sealed partial class SparseVector
    {
        /// <summary>
        /// Indices must be unique
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Indices { get; set; }

        /// <summary>
        /// Values and indices must be the same length
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<float> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVector" /> class.
        /// </summary>
        /// <param name="indices">
        /// Indices must be unique
        /// </param>
        /// <param name="values">
        /// Values and indices must be the same length
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseVector(
            global::System.Collections.Generic.IList<int> indices,
            global::System.Collections.Generic.IList<float> values)
        {
            this.Indices = indices ?? throw new global::System.ArgumentNullException(nameof(indices));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseVector" /> class.
        /// </summary>
        public SparseVector()
        {
        }
    }
}