//HintName: G.Models.MultiQueryResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of a multi-query.
    /// </summary>
    public sealed partial class MultiQueryResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SingleQueryResult> Results { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="MultiQueryResult" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="performance">
        /// The performance information for a query.
        /// </param>
        /// <param name="billing">
        /// The billing information for a query.
        /// </param>
        public MultiQueryResult(
            global::System.Collections.Generic.IList<global::G.SingleQueryResult> results,
            global::G.QueryPerformance performance,
            global::G.QueryBilling billing)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Performance = performance ?? throw new global::System.ArgumentNullException(nameof(performance));
            this.Billing = billing ?? throw new global::System.ArgumentNullException(nameof(billing));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiQueryResult" /> class.
        /// </summary>
        public MultiQueryResult()
        {
        }
    }
}