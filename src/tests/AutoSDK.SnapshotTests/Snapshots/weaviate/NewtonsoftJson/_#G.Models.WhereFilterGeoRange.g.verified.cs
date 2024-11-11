//HintName: G.Models.WhereFilterGeoRange.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// filter within a distance of a georange
    /// </summary>
    public sealed partial class WhereFilterGeoRange
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("geoCoordinates")]
        public global::G.GeoCoordinates? GeoCoordinates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("distance")]
        public global::G.WhereFilterGeoRangeDistance? Distance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhereFilterGeoRange" /> class.
        /// </summary>
        /// <param name="geoCoordinates"></param>
        /// <param name="distance"></param>
        public WhereFilterGeoRange(
            global::G.GeoCoordinates? geoCoordinates,
            global::G.WhereFilterGeoRangeDistance? distance)
        {
            this.GeoCoordinates = geoCoordinates;
            this.Distance = distance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhereFilterGeoRange" /> class.
        /// </summary>
        public WhereFilterGeoRange()
        {
        }
    }
}