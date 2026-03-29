//HintName: G.Models.SparseVector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a sparse vector using parallel arrays for indices and values.<br/>
    /// On deserialization: accepts both old format `{"indices": [...], "values": [...]}`<br/>
    /// and new format `{"#type": "sparse_vector", "indices": [...], "values": [...]}`.<br/>
    /// On serialization: always includes `#type` field with value `"sparse_vector"`.
    /// </summary>
    public sealed partial class SparseVector
    {
        /// <summary>
        /// Dimension indices
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Indices { get; set; }

        /// <summary>
        /// Tokens corresponding to each index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.IList<string>? Tokens { get; set; }

        /// <summary>
        /// Values corresponding to each index
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
        /// Dimension indices
        /// </param>
        /// <param name="values">
        /// Values corresponding to each index
        /// </param>
        /// <param name="tokens">
        /// Tokens corresponding to each index
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseVector(
            global::System.Collections.Generic.IList<int> indices,
            global::System.Collections.Generic.IList<float> values,
            global::System.Collections.Generic.IList<string>? tokens)
        {
            this.Indices = indices ?? throw new global::System.ArgumentNullException(nameof(indices));
            this.Tokens = tokens;
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