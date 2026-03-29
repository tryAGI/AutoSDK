//HintName: G.Models.NamedVector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dense vector data with name
    /// </summary>
    public sealed partial class NamedVector
    {
        /// <summary>
        /// Name of vector data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Vector data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<float> Vector { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedVector" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of vector data
        /// </param>
        /// <param name="vector">
        /// Vector data
        /// </param>
        public NamedVector(
            string name,
            global::System.Collections.Generic.IList<float> vector)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Vector = vector ?? throw new global::System.ArgumentNullException(nameof(vector));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedVector" /> class.
        /// </summary>
        public NamedVector()
        {
        }
    }
}