//HintName: G.Models.GetAccountBillingResponseCredits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Credit balance details. Only present when 'credits' is included in expand parameter.
    /// </summary>
    public sealed partial class GetAccountBillingResponseCredits
    {
        /// <summary>
        /// Current credit balance available on the account<br/>
        /// Example: 24.5F
        /// </summary>
        /// <example>24.5F</example>
        [global::Newtonsoft.Json.JsonProperty("current_balance", Required = global::Newtonsoft.Json.Required.Always)]
        public double CurrentBalance { get; set; } = default!;

        /// <summary>
        /// Currency code for the balance<br/>
        /// Example: USD
        /// </summary>
        /// <example>USD</example>
        [global::Newtonsoft.Json.JsonProperty("currency", Required = global::Newtonsoft.Json.Required.Always)]
        public string Currency { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountBillingResponseCredits" /> class.
        /// </summary>
        /// <param name="currentBalance">
        /// Current credit balance available on the account<br/>
        /// Example: 24.5F
        /// </param>
        /// <param name="currency">
        /// Currency code for the balance<br/>
        /// Example: USD
        /// </param>
        public GetAccountBillingResponseCredits(
            double currentBalance,
            string currency)
        {
            this.CurrentBalance = currentBalance;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountBillingResponseCredits" /> class.
        /// </summary>
        public GetAccountBillingResponseCredits()
        {
        }
    }
}