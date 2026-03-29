//HintName: G.Models.BodyShape.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyShape
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelVersion")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shapeParameters")]
        public global::System.Collections.Generic.IList<double>? ShapeParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_measurements")]
        public global::G.MeshMeasurements? MeshMeasurements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyShape" /> class.
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="modelVersion"></param>
        /// <param name="shapeParameters"></param>
        /// <param name="meshMeasurements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyShape(
            string? gender,
            string? modelVersion,
            global::System.Collections.Generic.IList<double>? shapeParameters,
            global::G.MeshMeasurements? meshMeasurements)
        {
            this.Gender = gender;
            this.ModelVersion = modelVersion;
            this.ShapeParameters = shapeParameters;
            this.MeshMeasurements = meshMeasurements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyShape" /> class.
        /// </summary>
        public BodyShape()
        {
        }
    }
}