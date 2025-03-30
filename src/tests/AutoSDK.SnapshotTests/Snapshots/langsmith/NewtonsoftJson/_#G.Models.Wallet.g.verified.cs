//HintName: G.Models.Wallet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Wallet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credit_balance_micros", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreditBalanceMicros { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inflight_balance_micros", Required = global::Newtonsoft.Json.Required.Always)]
        public int InflightBalanceMicros { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Wallet" /> class.
        /// </summary>
        /// <param name="creditBalanceMicros"></param>
        /// <param name="inflightBalanceMicros"></param>
        public Wallet(
            int creditBalanceMicros,
            int inflightBalanceMicros)
        {
            this.CreditBalanceMicros = creditBalanceMicros;
            this.InflightBalanceMicros = inflightBalanceMicros;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wallet" /> class.
        /// </summary>
        public Wallet()
        {
        }
    }
}