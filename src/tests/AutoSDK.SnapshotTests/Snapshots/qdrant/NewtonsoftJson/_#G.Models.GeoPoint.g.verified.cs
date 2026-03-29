//HintName: G.Models.GeoPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Geo point payload schema
    /// </summary>
    public sealed partial class GeoPoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lon", Required = global::Newtonsoft.Json.Required.Always)]
        public double Lon { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lat", Required = global::Newtonsoft.Json.Required.Always)]
        public double Lat { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoPoint" /> class.
        /// </summary>
        /// <param name="lon"></param>
        /// <param name="lat"></param>
        public GeoPoint(
            double lon,
            double lat)
        {
            this.Lon = lon;
            this.Lat = lat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoPoint" /> class.
        /// </summary>
        public GeoPoint()
        {
        }
    }
}