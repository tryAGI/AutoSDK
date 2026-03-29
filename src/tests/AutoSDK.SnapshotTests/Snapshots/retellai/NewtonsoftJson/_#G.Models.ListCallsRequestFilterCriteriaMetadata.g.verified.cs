//HintName: G.Models.ListCallsRequestFilterCriteriaMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter by metadata fields using dot notation (e.g., `metadata.customer_id`).<br/>
    /// Values are matched exactly as strings.<br/>
    /// Example: {"metadata.customer_id":["cust_123"]}
    /// </summary>
    public sealed partial class ListCallsRequestFilterCriteriaMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}