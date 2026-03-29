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
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SingleQueryResult> Results { get; set; }

        /// <summary>
        /// The performance information for a query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.QueryPerformance Performance { get; set; }

        /// <summary>
        /// The billing information for a query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.QueryBilling Billing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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