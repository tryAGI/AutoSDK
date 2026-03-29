//HintName: G.Models.Point3D.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 3D Point coordinates.<br/>
    /// Attributes:<br/>
    ///     z (float): The z-axis pixel coordinate of the point.
    /// </summary>
    public sealed partial class Point3D
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
        /// The z-axis pixel coordinate of the point
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("z", Required = global::Newtonsoft.Json.Required.Always)]
        public double Z { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Point3D" /> class.
        /// </summary>
        /// <param name="x">
        /// The x-axis pixel coordinate of the point
        /// </param>
        /// <param name="y">
        /// The y-axis pixel coordinate of the point
        /// </param>
        /// <param name="z">
        /// The z-axis pixel coordinate of the point
        /// </param>
        public Point3D(
            double x,
            double y,
            double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Point3D" /> class.
        /// </summary>
        public Point3D()
        {
        }
    }
}