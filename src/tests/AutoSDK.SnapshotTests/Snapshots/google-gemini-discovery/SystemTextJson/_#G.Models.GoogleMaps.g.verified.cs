//HintName: G.Models.GoogleMaps.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The GoogleMaps Tool that provides geospatial context for the user's query.
    /// </summary>
    public sealed partial class GoogleMaps
    {
        /// <summary>
        /// Optional. Whether to return a widget context token in the GroundingMetadata of the response. Developers can use the widget context token to render a Google Maps widget with geospatial context related to the places that the model references in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableWidget")]
        public bool? EnableWidget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMaps" /> class.
        /// </summary>
        /// <param name="enableWidget">
        /// Optional. Whether to return a widget context token in the GroundingMetadata of the response. Developers can use the widget context token to render a Google Maps widget with geospatial context related to the places that the model references in the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleMaps(
            bool? enableWidget)
        {
            this.EnableWidget = enableWidget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleMaps" /> class.
        /// </summary>
        public GoogleMaps()
        {
        }
    }
}