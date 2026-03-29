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
        [global::Newtonsoft.Json.JsonProperty("gender")]
        public string? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelVersion")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shapeParameters")]
        public global::System.Collections.Generic.IList<double>? ShapeParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mesh_measurements")]
        public global::G.MeshMeasurements? MeshMeasurements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyShape" /> class.
        /// </summary>
        /// <param name="gender"></param>
        /// <param name="modelVersion"></param>
        /// <param name="shapeParameters"></param>
        /// <param name="meshMeasurements"></param>
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