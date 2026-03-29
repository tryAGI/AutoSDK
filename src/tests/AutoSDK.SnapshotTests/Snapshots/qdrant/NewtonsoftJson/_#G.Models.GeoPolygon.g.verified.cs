//HintName: G.Models.GeoPolygon.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Geo filter request<br/>
    /// Matches coordinates inside the polygon, defined by `exterior` and `interiors`
    /// </summary>
    public sealed partial class GeoPolygon
    {
        /// <summary>
        /// Ordered sequence of GeoPoints representing the line
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exterior", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GeoLineString Exterior { get; set; } = default!;

        /// <summary>
        /// Interior lines (if present) bound holes within the surface each GeoLineString must consist of a minimum of 4 points, and the first and last points must be the same.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interiors")]
        public global::System.Collections.Generic.IList<global::G.GeoLineString>? Interiors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoPolygon" /> class.
        /// </summary>
        /// <param name="exterior">
        /// Ordered sequence of GeoPoints representing the line
        /// </param>
        /// <param name="interiors">
        /// Interior lines (if present) bound holes within the surface each GeoLineString must consist of a minimum of 4 points, and the first and last points must be the same.
        /// </param>
        public GeoPolygon(
            global::G.GeoLineString exterior,
            global::System.Collections.Generic.IList<global::G.GeoLineString>? interiors)
        {
            this.Exterior = exterior ?? throw new global::System.ArgumentNullException(nameof(exterior));
            this.Interiors = interiors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoPolygon" /> class.
        /// </summary>
        public GeoPolygon()
        {
        }
    }
}