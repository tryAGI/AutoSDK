//HintName: G.Models.GeoRadius.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Geo filter request<br/>
    /// Matches coordinates inside the circle of `radius` and center with coordinates `center`
    /// </summary>
    public sealed partial class GeoRadius
    {
        /// <summary>
        /// Geo point payload schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("center")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GeoPoint Center { get; set; }

        /// <summary>
        /// Radius of the area in meters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("radius")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Radius { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoRadius" /> class.
        /// </summary>
        /// <param name="center">
        /// Geo point payload schema
        /// </param>
        /// <param name="radius">
        /// Radius of the area in meters
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeoRadius(
            global::G.GeoPoint center,
            double radius)
        {
            this.Center = center ?? throw new global::System.ArgumentNullException(nameof(center));
            this.Radius = radius;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoRadius" /> class.
        /// </summary>
        public GeoRadius()
        {
        }
    }
}