//HintName: G.Models.WalletTransactionForBalanceResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WalletTransactionForBalanceResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletBalance")]
        public double? WalletBalance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionForBalanceResponseDto" /> class.
        /// </summary>
        /// <param name="walletBalance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WalletTransactionForBalanceResponseDto(
            double? walletBalance)
        {
            this.WalletBalance = walletBalance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionForBalanceResponseDto" /> class.
        /// </summary>
        public WalletTransactionForBalanceResponseDto()
        {
        }
    }
}