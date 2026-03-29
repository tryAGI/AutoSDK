//HintName: G.Models.LlamaParseSpreadsheetOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Spreadsheet (Excel, CSV, ODS) parsing options.
    /// </summary>
    public sealed partial class LlamaParseSpreadsheetOptions
    {
        /// <summary>
        /// Detect and extract multiple tables within a single sheet. Useful when spreadsheets contain several data regions separated by blank rows/columns
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detect_sub_tables_in_sheets")]
        public bool? DetectSubTablesInSheets { get; set; }

        /// <summary>
        /// Compute formula results instead of extracting formula text. Use when you need calculated values rather than formula definitions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("force_formula_computation_in_sheets")]
        public bool? ForceFormulaComputationInSheets { get; set; }

        /// <summary>
        /// Parse hidden sheets in addition to visible ones. By default, hidden sheets are skipped
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_hidden_sheets")]
        public bool? IncludeHiddenSheets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseSpreadsheetOptions" /> class.
        /// </summary>
        /// <param name="detectSubTablesInSheets">
        /// Detect and extract multiple tables within a single sheet. Useful when spreadsheets contain several data regions separated by blank rows/columns
        /// </param>
        /// <param name="forceFormulaComputationInSheets">
        /// Compute formula results instead of extracting formula text. Use when you need calculated values rather than formula definitions
        /// </param>
        /// <param name="includeHiddenSheets">
        /// Parse hidden sheets in addition to visible ones. By default, hidden sheets are skipped
        /// </param>
        public LlamaParseSpreadsheetOptions(
            bool? detectSubTablesInSheets,
            bool? forceFormulaComputationInSheets,
            bool? includeHiddenSheets)
        {
            this.DetectSubTablesInSheets = detectSubTablesInSheets;
            this.ForceFormulaComputationInSheets = forceFormulaComputationInSheets;
            this.IncludeHiddenSheets = includeHiddenSheets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseSpreadsheetOptions" /> class.
        /// </summary>
        public LlamaParseSpreadsheetOptions()
        {
        }
    }
}