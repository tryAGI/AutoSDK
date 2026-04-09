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
        [global::Newtonsoft.Json.JsonProperty("l", Required = global::Newtonsoft.Json.Required.Always)]
        public double L { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("t", Required = global::Newtonsoft.Json.Required.Always)]
        public double T { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("r", Required = global::Newtonsoft.Json.Required.Always)]
        public double R { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("b", Required = global::Newtonsoft.Json.Required.Always)]
        public double B { get; set; } = default!;

        /// <summary>
        /// CoordOrigin.<br/>
        /// Default Value: TOPLEFT
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("coord_origin")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CoordOriginJsonConverter))]
        public global::G.CoordOrigin? CoordOrigin { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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