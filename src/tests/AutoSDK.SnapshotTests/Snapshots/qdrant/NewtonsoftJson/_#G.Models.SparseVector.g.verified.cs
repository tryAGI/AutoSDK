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
        [global::Newtonsoft.Json.JsonProperty("indices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Indices { get; set; } = default!;

        /// <summary>
        /// Values and indices must be the same length
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<float> Values { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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