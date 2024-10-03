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
    }
}