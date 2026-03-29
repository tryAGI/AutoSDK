//HintName: G.Models.BoundingBox.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// BoundingBox.
    /// </summary>
    public sealed partial class BoundingBox
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("l")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double L { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("t")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double T { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("r")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double R { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double B { get; set; }

        /// <summary>
        /// CoordOrigin.<br/>
        /// Default Value: TOPLEFT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coord_origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CoordOriginJsonConverter))]
        public global::G.CoordOrigin? CoordOrigin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox" /> class.
        /// </summary>
        /// <param name="l"></param>
        /// <param name="t"></param>
        /// <param name="r"></param>
        /// <param name="b"></param>
        /// <param name="coordOrigin">
        /// CoordOrigin.<br/>
        /// Default Value: TOPLEFT
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BoundingBox(
            double l,
            double t,
            double r,
            double b,
            global::G.CoordOrigin? coordOrigin)
        {
            this.L = l;
            this.T = t;
            this.R = r;
            this.B = b;
            this.CoordOrigin = coordOrigin;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox" /> class.
        /// </summary>
        public BoundingBox()
        {
        }
    }
}