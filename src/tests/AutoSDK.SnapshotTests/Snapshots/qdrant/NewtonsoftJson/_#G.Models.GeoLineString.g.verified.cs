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
        [global::Newtonsoft.Json.JsonProperty("points", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GeoPoint> Points { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoLineString" /> class.
        /// </summary>
        /// <param name="points"></param>
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