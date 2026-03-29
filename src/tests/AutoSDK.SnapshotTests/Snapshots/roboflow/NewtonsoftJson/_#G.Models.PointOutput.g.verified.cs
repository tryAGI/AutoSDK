//HintName: G.Models.PointOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Point coordinates.<br/>
    /// Attributes:<br/>
    ///     x (float): The x-axis pixel coordinate of the point.<br/>
    ///     y (float): The y-axis pixel coordinate of the point.
    /// </summary>
    public sealed partial class PointOutput
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PointOutput" /> class.
        /// </summary>
        /// <param name="x">
        /// The x-axis pixel coordinate of the point
        /// </param>
        /// <param name="y">
        /// The y-axis pixel coordinate of the point
        /// </param>
        public PointOutput(
            double x,
            double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointOutput" /> class.
        /// </summary>
        public PointOutput()
        {
        }
    }
}