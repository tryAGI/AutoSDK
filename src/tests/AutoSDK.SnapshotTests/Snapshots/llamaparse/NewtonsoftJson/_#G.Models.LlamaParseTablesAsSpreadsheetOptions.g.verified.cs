//HintName: G.Models.LlamaParseTablesAsSpreadsheetOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for exporting extracted tables as XLSX spreadsheet files.
    /// </summary>
    public sealed partial class LlamaParseTablesAsSpreadsheetOptions
    {
        /// <summary>
        /// Whether this option is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Automatically generate descriptive sheet names from table context (headers, surrounding text) instead of using generic names like 'Table_1'<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guess_sheet_name")]
        public bool? GuessSheetName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseTablesAsSpreadsheetOptions" /> class.
        /// </summary>
        /// <param name="enable">
        /// Whether this option is enabled
        /// </param>
        /// <param name="guessSheetName">
        /// Automatically generate descriptive sheet names from table context (headers, surrounding text) instead of using generic names like 'Table_1'<br/>
        /// Default Value: true
        /// </param>
        public LlamaParseTablesAsSpreadsheetOptions(
            bool? enable,
            bool? guessSheetName)
        {
            this.Enable = enable;
            this.GuessSheetName = guessSheetName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseTablesAsSpreadsheetOptions" /> class.
        /// </summary>
        public LlamaParseTablesAsSpreadsheetOptions()
        {
        }
    }
}