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
        [global::Newtonsoft.Json.JsonProperty("billable_logical_bytes_queried", Required = global::Newtonsoft.Json.Required.Always)]
        public long BillableLogicalBytesQueried { get; set; } = default!;

        /// <summary>
        /// The number of billable logical bytes returned from the query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billable_logical_bytes_returned", Required = global::Newtonsoft.Json.Required.Always)]
        public long BillableLogicalBytesReturned { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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