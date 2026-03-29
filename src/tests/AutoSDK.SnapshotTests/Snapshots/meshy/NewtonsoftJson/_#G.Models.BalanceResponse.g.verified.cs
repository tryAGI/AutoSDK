//HintName: G.Models.BalanceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BalanceResponse
    {
        /// <summary>
        /// Current credit balance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("balance")]
        public int? Balance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponse" /> class.
        /// </summary>
        /// <param name="balance">
        /// Current credit balance
        /// </param>
        public BalanceResponse(
            int? balance)
        {
            this.Balance = balance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponse" /> class.
        /// </summary>
        public BalanceResponse()
        {
        }
    }
}