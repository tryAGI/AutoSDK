//HintName: G.Models.GeoLineString.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Ordered sequence of GeoPoints representing the line
    /// </summary>
    public sealed partial class GeoLineString
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GeoPoint> Points { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoLineString" /> class.
        /// </summary>
        /// <param name="points"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeoLineString(
            global::System.Collections.Generic.IList<global::G.GeoPoint> points)
        {
            this.Points = points ?? throw new global::System.ArgumentNullException(nameof(points));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoLineString" /> class.
        /// </summary>
        public GeoLineString()
        {
        }
    }
}