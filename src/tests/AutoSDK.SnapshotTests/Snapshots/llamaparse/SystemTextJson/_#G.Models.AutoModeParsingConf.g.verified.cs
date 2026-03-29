//HintName: G.Models.AutoModeParsingConf.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parsing configuration applied when auto mode triggers match.<br/>
    /// These settings override the base configuration for pages where trigger conditions<br/>
    /// are satisfied. Only specify fields you want to override - unset fields inherit<br/>
    /// from the base configuration.
    /// </summary>
    public sealed partial class AutoModeParsingConf
    {
        /// <summary>
        /// Override the parsing tier for matched pages. Must be paired with version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public global::G.AutoModeParsingConfTier2? Tier { get; set; }

        /// <summary>
        /// Tier version when overriding tier. Required when tier is specified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.AutoModeParsingConfVersion?, string, object>))]
        public global::G.AnyOf<global::G.AutoModeParsingConfVersion?, string, object>? Version { get; set; }

        /// <summary>
        /// Custom AI instructions for matched pages. Overrides the base custom_prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_prompt")]
        public string? CustomPrompt { get; set; }

        /// <summary>
        /// Options for ignoring specific text types
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore")]
        public global::G.AutoModeIgnoreOptions? Ignore { get; set; }

        /// <summary>
        /// Whether to use aggressive table extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggressive_table_extraction")]
        public bool? AggressiveTableExtraction { get; set; }

        /// <summary>
        /// Whether to use outlined table extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outlined_table_extraction")]
        public bool? OutlinedTableExtraction { get; set; }

        /// <summary>
        /// Whether to use adaptive long table handling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adaptive_long_table")]
        public bool? AdaptiveLongTable { get; set; }

        /// <summary>
        /// Whether to extract layout information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_layout")]
        public bool? ExtractLayout { get; set; }

        /// <summary>
        /// Enable specialized chart parsing with the specified mode
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specialized_chart_parsing")]
        public global::G.AutoModeParsingConfSpecializedChartParsing2? SpecializedChartParsing { get; set; }

        /// <summary>
        /// Whether to use high resolution OCR
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_res_ocr")]
        public bool? HighResOcr { get; set; }

        /// <summary>
        /// Primary language of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Document crop box boundaries
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_box")]
        public global::G.AutoModeCropBox? CropBox { get; set; }

        /// <summary>
        /// Spatial text output options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spatial_text")]
        public global::G.AutoModeSpatialTextOptions? SpatialText { get; set; }

        /// <summary>
        /// Presentation-specific parsing options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation")]
        public global::G.AutoModePresentationOptions? Presentation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModeParsingConf" /> class.
        /// </summary>
        /// <param name="tier">
        /// Override the parsing tier for matched pages. Must be paired with version
        /// </param>
        /// <param name="version">
        /// Tier version when overriding tier. Required when tier is specified
        /// </param>
        /// <param name="customPrompt">
        /// Custom AI instructions for matched pages. Overrides the base custom_prompt
        /// </param>
        /// <param name="ignore">
        /// Options for ignoring specific text types
        /// </param>
        /// <param name="aggressiveTableExtraction">
        /// Whether to use aggressive table extraction
        /// </param>
        /// <param name="outlinedTableExtraction">
        /// Whether to use outlined table extraction
        /// </param>
        /// <param name="adaptiveLongTable">
        /// Whether to use adaptive long table handling
        /// </param>
        /// <param name="extractLayout">
        /// Whether to extract layout information
        /// </param>
        /// <param name="specializedChartParsing">
        /// Enable specialized chart parsing with the specified mode
        /// </param>
        /// <param name="highResOcr">
        /// Whether to use high resolution OCR
        /// </param>
        /// <param name="language">
        /// Primary language of the document
        /// </param>
        /// <param name="cropBox">
        /// Document crop box boundaries
        /// </param>
        /// <param name="spatialText">
        /// Spatial text output options
        /// </param>
        /// <param name="presentation">
        /// Presentation-specific parsing options
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoModeParsingConf(
            global::G.AutoModeParsingConfTier2? tier,
            global::G.AnyOf<global::G.AutoModeParsingConfVersion?, string, object>? version,
            string? customPrompt,
            global::G.AutoModeIgnoreOptions? ignore,
            bool? aggressiveTableExtraction,
            bool? outlinedTableExtraction,
            bool? adaptiveLongTable,
            bool? extractLayout,
            global::G.AutoModeParsingConfSpecializedChartParsing2? specializedChartParsing,
            bool? highResOcr,
            string? language,
            global::G.AutoModeCropBox? cropBox,
            global::G.AutoModeSpatialTextOptions? spatialText,
            global::G.AutoModePresentationOptions? presentation)
        {
            this.Tier = tier;
            this.Version = version;
            this.CustomPrompt = customPrompt;
            this.Ignore = ignore;
            this.AggressiveTableExtraction = aggressiveTableExtraction;
            this.OutlinedTableExtraction = outlinedTableExtraction;
            this.AdaptiveLongTable = adaptiveLongTable;
            this.ExtractLayout = extractLayout;
            this.SpecializedChartParsing = specializedChartParsing;
            this.HighResOcr = highResOcr;
            this.Language = language;
            this.CropBox = cropBox;
            this.SpatialText = spatialText;
            this.Presentation = presentation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModeParsingConf" /> class.
        /// </summary>
        public AutoModeParsingConf()
        {
        }
    }
}