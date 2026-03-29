//HintName: G.Models.LlamaParseProcessingOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Processing options shared across all parsing tiers.<br/>
    /// These options control how documents are analyzed and processed regardless of the selected tier.<br/>
    /// Some options automatically enable additional behaviors (e.g., specialized_chart_parsing<br/>
    /// enables extract_layout and precise_bounding_box).
    /// </summary>
    public sealed partial class LlamaParseProcessingOptions
    {
        /// <summary>
        /// Options for ignoring specific text types (diagonal, hidden, text in images)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore")]
        public global::G.LlamaParseIgnoreOptions? Ignore { get; set; }

        /// <summary>
        /// OCR configuration including language detection settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocr_parameters")]
        public global::G.LlamaParseOcrParameters? OcrParameters { get; set; }

        /// <summary>
        /// Use aggressive heuristics to detect table boundaries, even without visible borders. Useful for documents with borderless or complex tables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggressive_table_extraction")]
        public bool? AggressiveTableExtraction { get; set; }

        /// <summary>
        /// Disable automatic heuristics including outlined table extraction and adaptive long table handling. Use when heuristics produce incorrect results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_heuristics")]
        public bool? DisableHeuristics { get; set; }

        /// <summary>
        /// Enable AI-powered chart analysis. Modes: 'efficient' (fast, lower cost), 'agentic' (balanced), 'agentic_plus' (highest accuracy). Automatically enables extract_layout and precise_bounding_box when set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specialized_chart_parsing")]
        public global::G.LlamaParseProcessingOptionsSpecializedChartParsing2? SpecializedChartParsing { get; set; }

        /// <summary>
        /// Cost optimization settings. Only available with 'agentic' or 'agentic_plus' tiers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_optimizer")]
        public global::G.LlamaParseCostOptimizerParameters? CostOptimizer { get; set; }

        /// <summary>
        /// Conditional processing rules that apply different parsing options based on page content, document structure, or filename patterns. Each entry defines trigger conditions and the parsing configuration to apply when triggered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_mode_configuration")]
        public global::System.Collections.Generic.IList<global::G.AutoModeConfigurationEntry>? AutoModeConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseProcessingOptions" /> class.
        /// </summary>
        /// <param name="ignore">
        /// Options for ignoring specific text types (diagonal, hidden, text in images)
        /// </param>
        /// <param name="ocrParameters">
        /// OCR configuration including language detection settings
        /// </param>
        /// <param name="aggressiveTableExtraction">
        /// Use aggressive heuristics to detect table boundaries, even without visible borders. Useful for documents with borderless or complex tables
        /// </param>
        /// <param name="disableHeuristics">
        /// Disable automatic heuristics including outlined table extraction and adaptive long table handling. Use when heuristics produce incorrect results
        /// </param>
        /// <param name="specializedChartParsing">
        /// Enable AI-powered chart analysis. Modes: 'efficient' (fast, lower cost), 'agentic' (balanced), 'agentic_plus' (highest accuracy). Automatically enables extract_layout and precise_bounding_box when set
        /// </param>
        /// <param name="costOptimizer">
        /// Cost optimization settings. Only available with 'agentic' or 'agentic_plus' tiers
        /// </param>
        /// <param name="autoModeConfiguration">
        /// Conditional processing rules that apply different parsing options based on page content, document structure, or filename patterns. Each entry defines trigger conditions and the parsing configuration to apply when triggered
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlamaParseProcessingOptions(
            global::G.LlamaParseIgnoreOptions? ignore,
            global::G.LlamaParseOcrParameters? ocrParameters,
            bool? aggressiveTableExtraction,
            bool? disableHeuristics,
            global::G.LlamaParseProcessingOptionsSpecializedChartParsing2? specializedChartParsing,
            global::G.LlamaParseCostOptimizerParameters? costOptimizer,
            global::System.Collections.Generic.IList<global::G.AutoModeConfigurationEntry>? autoModeConfiguration)
        {
            this.Ignore = ignore;
            this.OcrParameters = ocrParameters;
            this.AggressiveTableExtraction = aggressiveTableExtraction;
            this.DisableHeuristics = disableHeuristics;
            this.SpecializedChartParsing = specializedChartParsing;
            this.CostOptimizer = costOptimizer;
            this.AutoModeConfiguration = autoModeConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseProcessingOptions" /> class.
        /// </summary>
        public LlamaParseProcessingOptions()
        {
        }
    }
}