//HintName: G.Models.WalletTransactionForCreateRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WalletTransactionForCreateRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletTypeIdEnum")]
        public int? WalletTypeIdEnum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionForCreateRequestDto" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <param name="walletTypeIdEnum"></param>
        /// <param name="amount"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WalletTransactionForCreateRequestDto(
            long? userId,
            string? userName,
            int? walletTypeIdEnum,
            double? amount,
            string? description)
        {
            this.UserId = userId;
            this.UserName = userName;
            this.WalletTypeIdEnum = walletTypeIdEnum;
            this.Amount = amount;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionForCreateRequestDto" /> class.
        /// </summary>
        public WalletTransactionForCreateRequestDto()
        {
        }
    }
}