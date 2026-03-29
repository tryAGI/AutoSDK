//HintName: G.Models.FieldCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// All possible payload filtering conditions
    /// </summary>
    public sealed partial class FieldCondition
    {
        /// <summary>
        /// Payload key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Check if point has field with a given value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("match")]
        public global::G.MatchCondition? Match { get; set; }

        /// <summary>
        /// Check if points value lies in a given range
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("range")]
        public global::G.RangeInterface? Range { get; set; }

        /// <summary>
        /// Check if points geolocation lies in a given area
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("geo_bounding_box")]
        public global::G.GeoBoundingBox? GeoBoundingBox { get; set; }

        /// <summary>
        /// Check if geo point is within a given radius
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("geo_radius")]
        public global::G.GeoRadius? GeoRadius { get; set; }

        /// <summary>
        /// Check if geo point is within a given polygon
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("geo_polygon")]
        public global::G.GeoPolygon? GeoPolygon { get; set; }

        /// <summary>
        /// Check number of values of the field
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values_count")]
        public global::G.ValuesCount? ValuesCount { get; set; }

        /// <summary>
        /// Check that the field is empty, alternative syntax for `is_empty: "field_name"`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_empty")]
        public bool? IsEmpty { get; set; }

        /// <summary>
        /// Check that the field is null, alternative syntax for `is_null: "field_name"`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_null")]
        public bool? IsNull { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldCondition" /> class.
        /// </summary>
        /// <param name="key">
        /// Payload key
        /// </param>
        /// <param name="match">
        /// Check if point has field with a given value
        /// </param>
        /// <param name="range">
        /// Check if points value lies in a given range
        /// </param>
        /// <param name="geoBoundingBox">
        /// Check if points geolocation lies in a given area
        /// </param>
        /// <param name="geoRadius">
        /// Check if geo point is within a given radius
        /// </param>
        /// <param name="geoPolygon">
        /// Check if geo point is within a given polygon
        /// </param>
        /// <param name="valuesCount">
        /// Check number of values of the field
        /// </param>
        /// <param name="isEmpty">
        /// Check that the field is empty, alternative syntax for `is_empty: "field_name"`
        /// </param>
        /// <param name="isNull">
        /// Check that the field is null, alternative syntax for `is_null: "field_name"`
        /// </param>
        public FieldCondition(
            string key,
            global::G.MatchCondition? match,
            global::G.RangeInterface? range,
            global::G.GeoBoundingBox? geoBoundingBox,
            global::G.GeoRadius? geoRadius,
            global::G.GeoPolygon? geoPolygon,
            global::G.ValuesCount? valuesCount,
            bool? isEmpty,
            bool? isNull)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Match = match;
            this.Range = range;
            this.GeoBoundingBox = geoBoundingBox;
            this.GeoRadius = geoRadius;
            this.GeoPolygon = geoPolygon;
            this.ValuesCount = valuesCount;
            this.IsEmpty = isEmpty;
            this.IsNull = isNull;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldCondition" /> class.
        /// </summary>
        public FieldCondition()
        {
        }
    }
}