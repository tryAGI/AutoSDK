//HintName: G.Models.CaptionStyleVerticalPlacementModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CaptionStyleVerticalPlacementModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("align")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CaptionStyleVerticalPlacementModelAlignJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CaptionStyleVerticalPlacementModelAlign Align { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translate_pct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TranslatePct { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleVerticalPlacementModel" /> class.
        /// </summary>
        /// <param name="align"></param>
        /// <param name="translatePct"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptionStyleVerticalPlacementModel(
            global::G.CaptionStyleVerticalPlacementModelAlign align,
            double translatePct)
        {
            this.Align = align;
            this.TranslatePct = translatePct;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleVerticalPlacementModel" /> class.
        /// </summary>
        public CaptionStyleVerticalPlacementModel()
        {
        }
    }
}