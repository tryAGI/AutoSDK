//HintName: G.Models.CreateChagellyDepositRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChagellyDepositRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerCode")]
        public string? ProviderCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quickPay")]
        public bool? QuickPay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChagellyDepositRequestDto" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="amount"></param>
        /// <param name="providerCode"></param>
        /// <param name="quickPay"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChagellyDepositRequestDto(
            long? userId,
            double? amount,
            string? providerCode,
            bool? quickPay)
        {
            this.UserId = userId;
            this.Amount = amount;
            this.ProviderCode = providerCode;
            this.QuickPay = quickPay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChagellyDepositRequestDto" /> class.
        /// </summary>
        public CreateChagellyDepositRequestDto()
        {
        }
    }
}