//HintName: G.Models.BoxXYXY.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BoxXYXY
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x0", Required = global::Newtonsoft.Json.Required.Always)]
        public double X0 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y0", Required = global::Newtonsoft.Json.Required.Always)]
        public double Y0 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x1", Required = global::Newtonsoft.Json.Required.Always)]
        public double X1 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y1", Required = global::Newtonsoft.Json.Required.Always)]
        public double Y1 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BoxXYXY" /> class.
        /// </summary>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        public BoxXYXY(
            double x0,
            double y0,
            double x1,
            double y1)
        {
            this.X0 = x0;
            this.Y0 = y0;
            this.X1 = x1;
            this.Y1 = y1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoxXYXY" /> class.
        /// </summary>
        public BoxXYXY()
        {
        }
    }
}