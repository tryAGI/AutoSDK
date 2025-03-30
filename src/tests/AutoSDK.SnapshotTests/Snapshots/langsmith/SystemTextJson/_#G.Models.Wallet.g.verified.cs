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
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_balance_micros")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreditBalanceMicros { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inflight_balance_micros")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InflightBalanceMicros { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Wallet" /> class.
        /// </summary>
        /// <param name="creditBalanceMicros"></param>
        /// <param name="inflightBalanceMicros"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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