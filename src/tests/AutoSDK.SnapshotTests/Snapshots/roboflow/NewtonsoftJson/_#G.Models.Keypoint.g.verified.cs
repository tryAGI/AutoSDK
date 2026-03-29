//HintName: G.Models.Keypoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Keypoint
    {
        /// <summary>
        /// The x-axis pixel coordinate of the point
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x", Required = global::Newtonsoft.Json.Required.Always)]
        public double X { get; set; } = default!;

        /// <summary>
        /// The y-axis pixel coordinate of the point
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y", Required = global::Newtonsoft.Json.Required.Always)]
        public double Y { get; set; } = default!;

        /// <summary>
        /// Model confidence regarding keypoint visibility.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// Identifier of keypoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ClassId { get; set; } = default!;

        /// <summary>
        /// Type of keypoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class", Required = global::Newtonsoft.Json.Required.Always)]
        public string Class { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Keypoint" /> class.
        /// </summary>
        /// <param name="x">
        /// The x-axis pixel coordinate of the point
        /// </param>
        /// <param name="y">
        /// The y-axis pixel coordinate of the point
        /// </param>
        /// <param name="confidence">
        /// Model confidence regarding keypoint visibility.
        /// </param>
        /// <param name="classId">
        /// Identifier of keypoint.
        /// </param>
        /// <param name="class">
        /// Type of keypoint.
        /// </param>
        public Keypoint(
            double x,
            double y,
            double confidence,
            int classId,
            string @class)
        {
            this.X = x;
            this.Y = y;
            this.Confidence = confidence;
            this.ClassId = classId;
            this.Class = @class ?? throw new global::System.ArgumentNullException(nameof(@class));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Keypoint" /> class.
        /// </summary>
        public Keypoint()
        {
        }
    }
}