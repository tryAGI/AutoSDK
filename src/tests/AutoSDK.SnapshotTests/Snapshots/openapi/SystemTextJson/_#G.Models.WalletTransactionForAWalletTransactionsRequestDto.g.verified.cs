//HintName: G.Models.WalletTransactionForAWalletTransactionsRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WalletTransactionForAWalletTransactionsRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionForAWalletTransactionsRequestDto" /> class.
        /// </summary>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WalletTransactionForAWalletTransactionsRequestDto(
            long? userId)
        {
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionForAWalletTransactionsRequestDto" /> class.
        /// </summary>
        public WalletTransactionForAWalletTransactionsRequestDto()
        {
        }
    }
}