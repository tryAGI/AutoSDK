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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Sparse vector structure
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SparseVector Vector { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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