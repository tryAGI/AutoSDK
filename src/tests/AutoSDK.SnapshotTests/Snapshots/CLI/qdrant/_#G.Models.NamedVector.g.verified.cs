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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Vector data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<float> Vector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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