//HintName: G.Models.StructuredIndexingToolParametersDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The structured document to index with full hierarchical content.<br/>
    /// Example: {"id":"annual_report_2024","type":"structured","title":"2024 Annual ESG Report"}
    /// </summary>
    public sealed partial class StructuredIndexingToolParametersDocument
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}