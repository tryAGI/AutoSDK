//HintName: G.Models.QueryBilling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The billing information for a query.
    /// </summary>
    public sealed partial class QueryBilling
    {
        /// <summary>
        /// The number of billable logical bytes queried from the namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable_logical_bytes_queried")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BillableLogicalBytesQueried { get; set; }

        /// <summary>
        /// The number of billable logical bytes returned from the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable_logical_bytes_returned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BillableLogicalBytesReturned { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBilling" /> class.
        /// </summary>
        /// <param name="billableLogicalBytesQueried">
        /// The number of billable logical bytes queried from the namespace.
        /// </param>
        /// <param name="billableLogicalBytesReturned">
        /// The number of billable logical bytes returned from the query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryBilling(
            long billableLogicalBytesQueried,
            long billableLogicalBytesReturned)
        {
            this.BillableLogicalBytesQueried = billableLogicalBytesQueried;
            this.BillableLogicalBytesReturned = billableLogicalBytesReturned;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBilling" /> class.
        /// </summary>
        public QueryBilling()
        {
        }
    }
}