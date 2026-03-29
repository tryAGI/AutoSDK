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
        [global::Newtonsoft.Json.JsonProperty("totalCreditsPurchased", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCreditsPurchased { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("balance", Required = global::Newtonsoft.Json.Required.Always)]
        public double Balance { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditBalanceResponse" /> class.
        /// </summary>
        /// <param name="totalCreditsPurchased"></param>
        /// <param name="balance"></param>
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