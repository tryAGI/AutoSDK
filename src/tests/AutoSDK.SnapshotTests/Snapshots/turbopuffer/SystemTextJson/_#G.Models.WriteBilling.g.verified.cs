//HintName: G.Models.WriteBilling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The billing information for a write request.
    /// </summary>
    public sealed partial class WriteBilling
    {
        /// <summary>
        /// The number of billable logical bytes written to the namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable_logical_bytes_written")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BillableLogicalBytesWritten { get; set; }

        /// <summary>
        /// The billing information for a query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public global::G.QueryBilling? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteBilling" /> class.
        /// </summary>
        /// <param name="billableLogicalBytesWritten">
        /// The number of billable logical bytes written to the namespace.
        /// </param>
        /// <param name="query">
        /// The billing information for a query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WriteBilling(
            long billableLogicalBytesWritten,
            global::G.QueryBilling? query)
        {
            this.BillableLogicalBytesWritten = billableLogicalBytesWritten;
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteBilling" /> class.
        /// </summary>
        public WriteBilling()
        {
        }
    }
}