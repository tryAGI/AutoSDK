//HintName: G.Models.CreditBalanceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditBalanceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCreditsPurchased")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCreditsPurchased { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Balance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditBalanceResponse" /> class.
        /// </summary>
        /// <param name="totalCreditsPurchased"></param>
        /// <param name="balance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditBalanceResponse(
            double totalCreditsPurchased,
            double balance)
        {
            this.TotalCreditsPurchased = totalCreditsPurchased;
            this.Balance = balance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditBalanceResponse" /> class.
        /// </summary>
        public CreditBalanceResponse()
        {
        }
    }
}