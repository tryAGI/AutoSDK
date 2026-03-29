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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExtendedPointIdJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtendedPointId Id { get; set; }

        /// <summary>
        /// Full vector data per point separator with single and multiple vector modes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorStructJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VectorStruct Vector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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