//HintName: G.Models.GeoBoundingBox.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Geo filter request<br/>
    /// Matches coordinates inside the rectangle, described by coordinates of lop-left and bottom-right edges
    /// </summary>
    public sealed partial class GeoBoundingBox
    {
        /// <summary>
        /// Geo point payload schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_left")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GeoPoint TopLeft { get; set; }

        /// <summary>
        /// Geo point payload schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bottom_right")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GeoPoint BottomRight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoBoundingBox" /> class.
        /// </summary>
        /// <param name="topLeft">
        /// Geo point payload schema
        /// </param>
        /// <param name="bottomRight">
        /// Geo point payload schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeoBoundingBox(
            global::G.GeoPoint topLeft,
            global::G.GeoPoint bottomRight)
        {
            this.TopLeft = topLeft ?? throw new global::System.ArgumentNullException(nameof(topLeft));
            this.BottomRight = bottomRight ?? throw new global::System.ArgumentNullException(nameof(bottomRight));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoBoundingBox" /> class.
        /// </summary>
        public GeoBoundingBox()
        {
        }
    }
}