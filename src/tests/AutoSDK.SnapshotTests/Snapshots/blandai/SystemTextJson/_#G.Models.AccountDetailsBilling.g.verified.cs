//HintName: G.Models.AccountDetailsBilling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountDetailsBilling
    {
        /// <summary>
        /// Current credit balance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_balance")]
        public float? CurrentBalance { get; set; }

        /// <summary>
        /// Auto-refill threshold (null if disabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refill_to")]
        public float? RefillTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsBilling" /> class.
        /// </summary>
        /// <param name="currentBalance">
        /// Current credit balance
        /// </param>
        /// <param name="refillTo">
        /// Auto-refill threshold (null if disabled)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountDetailsBilling(
            float? currentBalance,
            float? refillTo)
        {
            this.CurrentBalance = currentBalance;
            this.RefillTo = refillTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountDetailsBilling" /> class.
        /// </summary>
        public AccountDetailsBilling()
        {
        }
    }
}