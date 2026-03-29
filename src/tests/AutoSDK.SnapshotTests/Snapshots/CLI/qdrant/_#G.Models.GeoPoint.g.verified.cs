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
        [global::System.Text.Json.Serialization.JsonPropertyName("lon")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Lon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lat")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Lat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoPoint" /> class.
        /// </summary>
        /// <param name="lon"></param>
        /// <param name="lat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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