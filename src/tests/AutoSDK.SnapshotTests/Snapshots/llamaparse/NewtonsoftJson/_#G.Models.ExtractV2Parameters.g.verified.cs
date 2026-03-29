//HintName: G.Models.ExtractV2Parameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Typed parameters for an *extract v2* product configuration.
    /// </summary>
    public sealed partial class ExtractV2Parameters
    {
        /// <summary>
        /// Comma-separated page numbers or ranges to process (1-based). Omit to process all pages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_pages")]
        public string? TargetPages { get; set; }

        /// <summary>
        /// Maximum number of pages to process. Omit for no limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_pages")]
        public int? MaxPages { get; set; }

        /// <summary>
        /// ISO 639-1 language code for the document<br/>
        /// Default Value: en
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lang")]
        public string? Lang { get; set; }

        /// <summary>
        /// Extract tier: cost_effective (5 credits/page) or agentic (15 credits/page)<br/>
        /// Default Value: cost_effective
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier")]
        public global::G.ExtractV2ParametersTier? Tier { get; set; }

        /// <summary>
        /// Extract algorithm version. Use 'latest' or a date string.<br/>
        /// Default Value: latest
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extract_version")]
        public string? ExtractVersion { get; set; }

        /// <summary>
        /// JSON Schema defining the fields to extract. Validate with the /schema/validate endpoint first.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object DataSchema { get; set; } = default!;

        /// <summary>
        /// Granularity of extraction: per_doc returns one object per document, per_page returns one object per page, per_table_row returns one object per table row<br/>
        /// Default Value: per_doc
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extraction_target")]
        public global::G.ExtractV2ParametersExtractionTarget? ExtractionTarget { get; set; }

        /// <summary>
        /// Custom system prompt to guide extraction behavior
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Include citations in results<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cite_sources")]
        public bool? CiteSources { get; set; }

        /// <summary>
        /// Include confidence scores in results<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence_scores")]
        public bool? ConfidenceScores { get; set; }

        /// <summary>
        /// Parse tier to use before extraction (fast, cost_effective, or agentic)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parse_tier")]
        public string? ParseTier { get; set; }

        /// <summary>
        /// Saved parse configuration ID to control how the document is parsed before extraction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parse_config_id")]
        public string? ParseConfigId { get; set; }

        /// <summary>
        /// Product type.
        /// </summary>
        /// <default>"extract_v2"</default>
        [global::Newtonsoft.Json.JsonProperty("product_type")]
        public string ProductType { get; set; } = "extract_v2";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2Parameters" /> class.
        /// </summary>
        /// <param name="dataSchema">
        /// JSON Schema defining the fields to extract. Validate with the /schema/validate endpoint first.
        /// </param>
        /// <param name="targetPages">
        /// Comma-separated page numbers or ranges to process (1-based). Omit to process all pages.
        /// </param>
        /// <param name="maxPages">
        /// Maximum number of pages to process. Omit for no limit.
        /// </param>
        /// <param name="lang">
        /// ISO 639-1 language code for the document<br/>
        /// Default Value: en
        /// </param>
        /// <param name="tier">
        /// Extract tier: cost_effective (5 credits/page) or agentic (15 credits/page)<br/>
        /// Default Value: cost_effective
        /// </param>
        /// <param name="extractVersion">
        /// Extract algorithm version. Use 'latest' or a date string.<br/>
        /// Default Value: latest
        /// </param>
        /// <param name="extractionTarget">
        /// Granularity of extraction: per_doc returns one object per document, per_page returns one object per page, per_table_row returns one object per table row<br/>
        /// Default Value: per_doc
        /// </param>
        /// <param name="systemPrompt">
        /// Custom system prompt to guide extraction behavior
        /// </param>
        /// <param name="citeSources">
        /// Include citations in results<br/>
        /// Default Value: false
        /// </param>
        /// <param name="confidenceScores">
        /// Include confidence scores in results<br/>
        /// Default Value: false
        /// </param>
        /// <param name="parseTier">
        /// Parse tier to use before extraction (fast, cost_effective, or agentic)
        /// </param>
        /// <param name="parseConfigId">
        /// Saved parse configuration ID to control how the document is parsed before extraction
        /// </param>
        /// <param name="productType">
        /// Product type.
        /// </param>
        public ExtractV2Parameters(
            object dataSchema,
            string? targetPages,
            int? maxPages,
            string? lang,
            global::G.ExtractV2ParametersTier? tier,
            string? extractVersion,
            global::G.ExtractV2ParametersExtractionTarget? extractionTarget,
            string? systemPrompt,
            bool? citeSources,
            bool? confidenceScores,
            string? parseTier,
            string? parseConfigId,
            string productType = "extract_v2")
        {
            this.TargetPages = targetPages;
            this.MaxPages = maxPages;
            this.Lang = lang;
            this.Tier = tier;
            this.ExtractVersion = extractVersion;
            this.DataSchema = dataSchema ?? throw new global::System.ArgumentNullException(nameof(dataSchema));
            this.ExtractionTarget = extractionTarget;
            this.SystemPrompt = systemPrompt;
            this.CiteSources = citeSources;
            this.ConfidenceScores = confidenceScores;
            this.ParseTier = parseTier;
            this.ParseConfigId = parseConfigId;
            this.ProductType = productType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2Parameters" /> class.
        /// </summary>
        public ExtractV2Parameters()
        {
        }
    }
}