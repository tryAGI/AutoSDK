//HintName: G.Models.SpreadsheetParsingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for spreadsheet parsing and region extraction
    /// </summary>
    public sealed partial class SpreadsheetParsingConfig
    {
        /// <summary>
        /// The names of the sheets to extract regions from. If empty, all sheets will be processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sheet_names")]
        public global::System.Collections.Generic.IList<string>? SheetNames { get; set; }

        /// <summary>
        /// Whether to include hidden cells when extracting regions from the spreadsheet.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_hidden_cells")]
        public bool? IncludeHiddenCells { get; set; }

        /// <summary>
        /// A1 notation of the range to extract a single region from. If None, the entire sheet is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extraction_range")]
        public string? ExtractionRange { get; set; }

        /// <summary>
        /// Whether to generate additional metadata (title, description) for each extracted region.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_additional_metadata")]
        public bool? GenerateAdditionalMetadata { get; set; }

        /// <summary>
        /// Enables experimental processing. Accuracy may be impacted.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_experimental_processing")]
        public bool? UseExperimentalProcessing { get; set; }

        /// <summary>
        /// Return a flattened dataframe when a detected table is recognized as hierarchical.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatten_hierarchical_tables")]
        public bool? FlattenHierarchicalTables { get; set; }

        /// <summary>
        /// Influences how likely similar-looking regions are merged into a single table. Useful for spreadsheets that either have sparse tables (strong merging) or many distinct tables close together (weak merging).<br/>
        /// Default Value: strong
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_merge_sensitivity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpreadsheetParsingConfigTableMergeSensitivityJsonConverter))]
        public global::G.SpreadsheetParsingConfigTableMergeSensitivity? TableMergeSensitivity { get; set; }

        /// <summary>
        /// Optional specialization mode for domain-specific extraction. Supported values: 'financial-standard', 'financial-enhanced', 'financial-precise'. Default None uses the general-purpose pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specialization")]
        public string? Specialization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetParsingConfig" /> class.
        /// </summary>
        /// <param name="sheetNames">
        /// The names of the sheets to extract regions from. If empty, all sheets will be processed.
        /// </param>
        /// <param name="includeHiddenCells">
        /// Whether to include hidden cells when extracting regions from the spreadsheet.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="extractionRange">
        /// A1 notation of the range to extract a single region from. If None, the entire sheet is used.
        /// </param>
        /// <param name="generateAdditionalMetadata">
        /// Whether to generate additional metadata (title, description) for each extracted region.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="useExperimentalProcessing">
        /// Enables experimental processing. Accuracy may be impacted.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="flattenHierarchicalTables">
        /// Return a flattened dataframe when a detected table is recognized as hierarchical.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tableMergeSensitivity">
        /// Influences how likely similar-looking regions are merged into a single table. Useful for spreadsheets that either have sparse tables (strong merging) or many distinct tables close together (weak merging).<br/>
        /// Default Value: strong
        /// </param>
        /// <param name="specialization">
        /// Optional specialization mode for domain-specific extraction. Supported values: 'financial-standard', 'financial-enhanced', 'financial-precise'. Default None uses the general-purpose pipeline.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpreadsheetParsingConfig(
            global::System.Collections.Generic.IList<string>? sheetNames,
            bool? includeHiddenCells,
            string? extractionRange,
            bool? generateAdditionalMetadata,
            bool? useExperimentalProcessing,
            bool? flattenHierarchicalTables,
            global::G.SpreadsheetParsingConfigTableMergeSensitivity? tableMergeSensitivity,
            string? specialization)
        {
            this.SheetNames = sheetNames;
            this.IncludeHiddenCells = includeHiddenCells;
            this.ExtractionRange = extractionRange;
            this.GenerateAdditionalMetadata = generateAdditionalMetadata;
            this.UseExperimentalProcessing = useExperimentalProcessing;
            this.FlattenHierarchicalTables = flattenHierarchicalTables;
            this.TableMergeSensitivity = tableMergeSensitivity;
            this.Specialization = specialization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetParsingConfig" /> class.
        /// </summary>
        public SpreadsheetParsingConfig()
        {
        }
    }
}