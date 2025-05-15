//HintName: G.Models.UsageMonth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageMonth
    {
        /// <summary>
        /// YYYY.MM formatted period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Period { get; set; }

        /// <summary>
        /// Inclusive, in ms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TimeInterval Interval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UsageItem> Items { get; set; }

        /// <summary>
        /// total cost for all items in cents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCost { get; set; }

        /// <summary>
        /// Stripe Invoice ID, or EMPTY|NOT_FINAL<br/>
        /// Default Value: NOT_FINAL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_id")]
        public string? InvoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMonth" /> class.
        /// </summary>
        /// <param name="period">
        /// YYYY.MM formatted period
        /// </param>
        /// <param name="interval">
        /// Inclusive, in ms
        /// </param>
        /// <param name="items"></param>
        /// <param name="totalCost">
        /// total cost for all items in cents
        /// </param>
        /// <param name="invoiceId">
        /// Stripe Invoice ID, or EMPTY|NOT_FINAL<br/>
        /// Default Value: NOT_FINAL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageMonth(
            string period,
            global::G.TimeInterval interval,
            global::System.Collections.Generic.IList<global::G.UsageItem> items,
            int totalCost,
            string? invoiceId)
        {
            this.Period = period ?? throw new global::System.ArgumentNullException(nameof(period));
            this.Interval = interval ?? throw new global::System.ArgumentNullException(nameof(interval));
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.TotalCost = totalCost;
            this.InvoiceId = invoiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMonth" /> class.
        /// </summary>
        public UsageMonth()
        {
        }
    }
}