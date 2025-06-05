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
        [global::Newtonsoft.Json.JsonProperty("period", Required = global::Newtonsoft.Json.Required.Always)]
        public string Period { get; set; } = default!;

        /// <summary>
        /// Inclusive, in ms
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interval", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TimeInterval Interval { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UsageItem> Items { get; set; } = default!;

        /// <summary>
        /// total cost for all items in cents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCost { get; set; } = default!;

        /// <summary>
        /// Stripe Invoice ID, or EMPTY|NOT_FINAL<br/>
        /// Default Value: NOT_FINAL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invoice_id")]
        public string? InvoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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