//HintName: G.Models.TableExtractionConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for table extraction from the document. This is optional and if not provided, default table extraction behavior will be used.
    /// </summary>
    public sealed partial class TableExtractionConfig
    {
        /// <summary>
        /// If set to true, the platform will attempt to extract tables from the document.<br/>
        /// The tables will be indexed as separate document parts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extract_tables", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ExtractTables { get; set; } = default!;

        /// <summary>
        /// Specification for which table extractor to use. If not specified, the platform uses the default extractor.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extractor")]
        public global::G.TableExtractorSpec? Extractor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableExtractionConfig" /> class.
        /// </summary>
        /// <param name="extractTables">
        /// If set to true, the platform will attempt to extract tables from the document.<br/>
        /// The tables will be indexed as separate document parts.
        /// </param>
        /// <param name="extractor">
        /// Specification for which table extractor to use. If not specified, the platform uses the default extractor.
        /// </param>
        public TableExtractionConfig(
            bool extractTables,
            global::G.TableExtractorSpec? extractor)
        {
            this.ExtractTables = extractTables;
            this.Extractor = extractor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableExtractionConfig" /> class.
        /// </summary>
        public TableExtractionConfig()
        {
        }
    }
}