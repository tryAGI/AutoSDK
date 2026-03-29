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
        [global::Newtonsoft.Json.JsonProperty("center", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GeoPoint Center { get; set; } = default!;

        /// <summary>
        /// Radius of the area in meters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("radius", Required = global::Newtonsoft.Json.Required.Always)]
        public double Radius { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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