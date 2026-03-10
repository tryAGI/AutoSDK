//HintName: G.Models.CaptionStyleModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CaptionStyleModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("template")]
        public global::G.CaptionStyleTemplateModel? Template { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_font")]
        public string? TextFont { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_scale")]
        public double? TextScale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_color")]
        public string? TextColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_align")]
        public global::G.CaptionStyleModelTextAlign2? TextAlign { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_style")]
        public global::G.CaptionStyleModelTextStyle2? TextStyle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_weight")]
        public global::G.CaptionStyleModelTextWeight2? TextWeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_shadow")]
        public global::G.StudioTextStyleShadowModel? TextShadow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_outline")]
        public global::G.StudioTextStyleOutlineModel? TextOutline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_enabled")]
        public bool? BackgroundEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_color")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background_opacity")]
        public double? BackgroundOpacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word_highlights_enabled")]
        public bool? WordHighlightsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word_highlights_color")]
        public string? WordHighlightsColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word_highlights_background_color")]
        public string? WordHighlightsBackgroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word_highlights_opacity")]
        public double? WordHighlightsOpacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("section_animation")]
        public global::G.CaptionStyleSectionAnimationModel? SectionAnimation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("word_animation")]
        public global::G.CaptionStyleWordAnimationModel? WordAnimation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_animation")]
        public global::G.CaptionStyleCharacterAnimationModel? CharacterAnimation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width_pct")]
        public double? WidthPct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("horizontal_placement")]
        public global::G.CaptionStyleHorizontalPlacementModel? HorizontalPlacement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vertical_placement")]
        public global::G.CaptionStyleVerticalPlacementModel? VerticalPlacement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_break_enabled")]
        public bool? AutoBreakEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_lines_per_section")]
        public int? MaxLinesPerSection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_words_per_line")]
        public int? MaxWordsPerLine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleModel" /> class.
        /// </summary>
        /// <param name="template"></param>
        /// <param name="textFont"></param>
        /// <param name="textScale"></param>
        /// <param name="textColor"></param>
        /// <param name="textAlign"></param>
        /// <param name="textStyle"></param>
        /// <param name="textWeight"></param>
        /// <param name="textShadow"></param>
        /// <param name="textOutline"></param>
        /// <param name="backgroundEnabled"></param>
        /// <param name="backgroundColor"></param>
        /// <param name="backgroundOpacity"></param>
        /// <param name="wordHighlightsEnabled"></param>
        /// <param name="wordHighlightsColor"></param>
        /// <param name="wordHighlightsBackgroundColor"></param>
        /// <param name="wordHighlightsOpacity"></param>
        /// <param name="sectionAnimation"></param>
        /// <param name="wordAnimation"></param>
        /// <param name="characterAnimation"></param>
        /// <param name="widthPct"></param>
        /// <param name="horizontalPlacement"></param>
        /// <param name="verticalPlacement"></param>
        /// <param name="autoBreakEnabled"></param>
        /// <param name="maxLinesPerSection"></param>
        /// <param name="maxWordsPerLine"></param>
        public CaptionStyleModel(
            global::G.CaptionStyleTemplateModel? template,
            string? textFont,
            double? textScale,
            string? textColor,
            global::G.CaptionStyleModelTextAlign2? textAlign,
            global::G.CaptionStyleModelTextStyle2? textStyle,
            global::G.CaptionStyleModelTextWeight2? textWeight,
            global::G.StudioTextStyleShadowModel? textShadow,
            global::G.StudioTextStyleOutlineModel? textOutline,
            bool? backgroundEnabled,
            string? backgroundColor,
            double? backgroundOpacity,
            bool? wordHighlightsEnabled,
            string? wordHighlightsColor,
            string? wordHighlightsBackgroundColor,
            double? wordHighlightsOpacity,
            global::G.CaptionStyleSectionAnimationModel? sectionAnimation,
            global::G.CaptionStyleWordAnimationModel? wordAnimation,
            global::G.CaptionStyleCharacterAnimationModel? characterAnimation,
            double? widthPct,
            global::G.CaptionStyleHorizontalPlacementModel? horizontalPlacement,
            global::G.CaptionStyleVerticalPlacementModel? verticalPlacement,
            bool? autoBreakEnabled,
            int? maxLinesPerSection,
            int? maxWordsPerLine)
        {
            this.Template = template;
            this.TextFont = textFont;
            this.TextScale = textScale;
            this.TextColor = textColor;
            this.TextAlign = textAlign;
            this.TextStyle = textStyle;
            this.TextWeight = textWeight;
            this.TextShadow = textShadow;
            this.TextOutline = textOutline;
            this.BackgroundEnabled = backgroundEnabled;
            this.BackgroundColor = backgroundColor;
            this.BackgroundOpacity = backgroundOpacity;
            this.WordHighlightsEnabled = wordHighlightsEnabled;
            this.WordHighlightsColor = wordHighlightsColor;
            this.WordHighlightsBackgroundColor = wordHighlightsBackgroundColor;
            this.WordHighlightsOpacity = wordHighlightsOpacity;
            this.SectionAnimation = sectionAnimation;
            this.WordAnimation = wordAnimation;
            this.CharacterAnimation = characterAnimation;
            this.WidthPct = widthPct;
            this.HorizontalPlacement = horizontalPlacement;
            this.VerticalPlacement = verticalPlacement;
            this.AutoBreakEnabled = autoBreakEnabled;
            this.MaxLinesPerSection = maxLinesPerSection;
            this.MaxWordsPerLine = maxWordsPerLine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleModel" /> class.
        /// </summary>
        public CaptionStyleModel()
        {
        }
    }
}