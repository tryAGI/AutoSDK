//HintName: G.Models.LatLng.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that represents a latitude/longitude pair. This is expressed as a pair of doubles to represent degrees latitude and degrees longitude. Unless specified otherwise, this object must conform to the WGS84 standard. Values must be within normalized ranges.
    /// </summary>
    public sealed partial class LatLng
    {
        /// <summary>
        /// The latitude in degrees. It must be in the range [-90.0, +90.0].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// The longitude in degrees. It must be in the range [-180.0, +180.0].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LatLng" /> class.
        /// </summary>
        /// <param name="latitude">
        /// The latitude in degrees. It must be in the range [-90.0, +90.0].
        /// </param>
        /// <param name="longitude">
        /// The longitude in degrees. It must be in the range [-180.0, +180.0].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LatLng(
            double? latitude,
            double? longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LatLng" /> class.
        /// </summary>
        public LatLng()
        {
        }
    }
}