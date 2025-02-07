//HintName: G.Models.GeoCoordinates.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeoCoordinates
    {
        /// <summary>
        /// The latitude of the point on earth in decimal form
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latitude")]
        public float? Latitude { get; set; }

        /// <summary>
        /// The longitude of the point on earth in decimal form
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longitude")]
        public float? Longitude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoCoordinates" /> class.
        /// </summary>
        /// <param name="latitude">
        /// The latitude of the point on earth in decimal form
        /// </param>
        /// <param name="longitude">
        /// The longitude of the point on earth in decimal form
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeoCoordinates(
            float? latitude,
            float? longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoCoordinates" /> class.
        /// </summary>
        public GeoCoordinates()
        {
        }
    }
}