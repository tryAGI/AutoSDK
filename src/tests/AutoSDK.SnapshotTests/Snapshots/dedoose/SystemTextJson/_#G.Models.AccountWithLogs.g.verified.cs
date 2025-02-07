//HintName: G.Models.AccountWithLogs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountWithLogs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountData")]
        public global::G.AccountVO2? AccountData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingTransactionItems")]
        public global::System.Collections.Generic.IList<global::G.BillingTransaction>? BillingTransactionItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creditTransactionItems")]
        public global::System.Collections.Generic.IList<global::G.CreditTransaction>? CreditTransactionItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountWithLogs" /> class.
        /// </summary>
        /// <param name="accountData"></param>
        /// <param name="billingTransactionItems"></param>
        /// <param name="creditTransactionItems"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountWithLogs(
            global::G.AccountVO2? accountData,
            global::System.Collections.Generic.IList<global::G.BillingTransaction>? billingTransactionItems,
            global::System.Collections.Generic.IList<global::G.CreditTransaction>? creditTransactionItems)
        {
            this.AccountData = accountData;
            this.BillingTransactionItems = billingTransactionItems;
            this.CreditTransactionItems = creditTransactionItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountWithLogs" /> class.
        /// </summary>
        public AccountWithLogs()
        {
        }
    }
}