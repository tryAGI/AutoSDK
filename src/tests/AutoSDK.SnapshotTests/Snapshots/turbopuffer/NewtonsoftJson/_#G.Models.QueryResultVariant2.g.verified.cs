//HintName: G.Models.QueryResultVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryResultVariant2
    {
        /// <summary>
        /// The performance information for a query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("performance", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.QueryPerformance Performance { get; set; } = default!;

        /// <summary>
        /// The billing information for a query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.QueryBilling Billing { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResultVariant2" /> class.
        /// </summary>
        /// <param name="performance">
        /// The performance information for a query.
        /// </param>
        /// <param name="billing">
        /// The billing information for a query.
        /// </param>
        public QueryResultVariant2(
            global::G.QueryPerformance performance,
            global::G.QueryBilling billing)
        {
            this.Performance = performance ?? throw new global::System.ArgumentNullException(nameof(performance));
            this.Billing = billing ?? throw new global::System.ArgumentNullException(nameof(billing));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResultVariant2" /> class.
        /// </summary>
        public QueryResultVariant2()
        {
        }
    }
}