//HintName: G.Models.CaptionStyleHorizontalPlacementModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CaptionStyleHorizontalPlacementModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("align", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CaptionStyleHorizontalPlacementModelAlign Align { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("translate_pct", Required = global::Newtonsoft.Json.Required.Always)]
        public double TranslatePct { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleHorizontalPlacementModel" /> class.
        /// </summary>
        /// <param name="align"></param>
        /// <param name="translatePct"></param>
        public CaptionStyleHorizontalPlacementModel(
            global::G.CaptionStyleHorizontalPlacementModelAlign align,
            double translatePct)
        {
            this.Align = align;
            this.TranslatePct = translatePct;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleHorizontalPlacementModel" /> class.
        /// </summary>
        public CaptionStyleHorizontalPlacementModel()
        {
        }
    }
}