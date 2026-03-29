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
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double X { get; set; }

        /// <summary>
        /// The y-axis pixel coordinate of the point
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Y { get; set; }

        /// <summary>
        /// The z-axis pixel coordinate of the point
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("z")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Z { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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