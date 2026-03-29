//HintName: G.Models.PointVectors.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PointVectors
    {
        /// <summary>
        /// Type, used for specifying point ID in user interface
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtendedPointId Id { get; set; } = default!;

        /// <summary>
        /// Full vector data per point separator with single and multiple vector modes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VectorStruct Vector { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PointVectors" /> class.
        /// </summary>
        /// <param name="id">
        /// Type, used for specifying point ID in user interface
        /// </param>
        /// <param name="vector">
        /// Full vector data per point separator with single and multiple vector modes
        /// </param>
        public PointVectors(
            global::G.ExtendedPointId id,
            global::G.VectorStruct vector)
        {
            this.Id = id;
            this.Vector = vector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointVectors" /> class.
        /// </summary>
        public PointVectors()
        {
        }
    }
}