//HintName: G.Models.WalletTransactionForListByUserResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WalletTransactionForListByUserResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletId")]
        public long? WalletId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeStamp")]
        public global::System.DateTime? TimeStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletTypeIdEnum")]
        public int? WalletTypeIdEnum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remoteTransactionId")]
        public long? RemoteTransactionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        public bool? Completed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payoutPeriodId")]
        public int? PayoutPeriodId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionForListByUserResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="walletId"></param>
        /// <param name="timeStamp"></param>
        /// <param name="walletTypeIdEnum"></param>
        /// <param name="description"></param>
        /// <param name="amount"></param>
        /// <param name="remoteTransactionId"></param>
        /// <param name="completed"></param>
        /// <param name="payoutPeriodId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WalletTransactionForListByUserResponseDto(
            long? id,
            long? userId,
            long? walletId,
            global::System.DateTime? timeStamp,
            int? walletTypeIdEnum,
            string? description,
            double? amount,
            long? remoteTransactionId,
            bool? completed,
            int? payoutPeriodId)
        {
            this.Id = id;
            this.UserId = userId;
            this.WalletId = walletId;
            this.TimeStamp = timeStamp;
            this.WalletTypeIdEnum = walletTypeIdEnum;
            this.Description = description;
            this.Amount = amount;
            this.RemoteTransactionId = remoteTransactionId;
            this.Completed = completed;
            this.PayoutPeriodId = payoutPeriodId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionForListByUserResponseDto" /> class.
        /// </summary>
        public WalletTransactionForListByUserResponseDto()
        {
        }
    }
}