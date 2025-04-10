//HintName: G.Models.CustomerForDetailResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomerForDetailResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btcWithdrawalAddress")]
        public string? BtcWithdrawalAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cebotWithdrawalAddress")]
        public string? CebotWithdrawalAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withdrawalAddressLastUpdated")]
        public global::System.DateTime? WithdrawalAddressLastUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDateUtc")]
        public global::System.DateTime? CreatedDateUtc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModifiedBy")]
        public string? LastModifiedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModifiedDateUtc")]
        public global::System.DateTime? LastModifiedDateUtc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learnWorldsUserId")]
        public string? LearnWorldsUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upLineUserId")]
        public long? UpLineUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upLineLegNo")]
        public int? UpLineLegNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referralUserId")]
        public long? ReferralUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentCapping")]
        public double? CurrentCapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDeleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoPurchaseDWallet")]
        public bool? AutoPurchaseDWallet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cappingRemaining")]
        public double? CappingRemaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membershipQuantity")]
        public int? MembershipQuantity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerForDetailResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="btcWithdrawalAddress"></param>
        /// <param name="cebotWithdrawalAddress"></param>
        /// <param name="withdrawalAddressLastUpdated"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdDateUtc"></param>
        /// <param name="lastModifiedBy"></param>
        /// <param name="lastModifiedDateUtc"></param>
        /// <param name="learnWorldsUserId"></param>
        /// <param name="upLineUserId"></param>
        /// <param name="upLineLegNo"></param>
        /// <param name="referralUserId"></param>
        /// <param name="currentCapping"></param>
        /// <param name="isActive"></param>
        /// <param name="isDeleted"></param>
        /// <param name="autoPurchaseDWallet"></param>
        /// <param name="cappingRemaining"></param>
        /// <param name="membershipQuantity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerForDetailResponseDto(
            long? id,
            string? btcWithdrawalAddress,
            string? cebotWithdrawalAddress,
            global::System.DateTime? withdrawalAddressLastUpdated,
            string? createdBy,
            global::System.DateTime? createdDateUtc,
            string? lastModifiedBy,
            global::System.DateTime? lastModifiedDateUtc,
            string? learnWorldsUserId,
            long? upLineUserId,
            int? upLineLegNo,
            long? referralUserId,
            double? currentCapping,
            bool? isActive,
            bool? isDeleted,
            bool? autoPurchaseDWallet,
            double? cappingRemaining,
            int? membershipQuantity)
        {
            this.Id = id;
            this.BtcWithdrawalAddress = btcWithdrawalAddress;
            this.CebotWithdrawalAddress = cebotWithdrawalAddress;
            this.WithdrawalAddressLastUpdated = withdrawalAddressLastUpdated;
            this.CreatedBy = createdBy;
            this.CreatedDateUtc = createdDateUtc;
            this.LastModifiedBy = lastModifiedBy;
            this.LastModifiedDateUtc = lastModifiedDateUtc;
            this.LearnWorldsUserId = learnWorldsUserId;
            this.UpLineUserId = upLineUserId;
            this.UpLineLegNo = upLineLegNo;
            this.ReferralUserId = referralUserId;
            this.CurrentCapping = currentCapping;
            this.IsActive = isActive;
            this.IsDeleted = isDeleted;
            this.AutoPurchaseDWallet = autoPurchaseDWallet;
            this.CappingRemaining = cappingRemaining;
            this.MembershipQuantity = membershipQuantity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerForDetailResponseDto" /> class.
        /// </summary>
        public CustomerForDetailResponseDto()
        {
        }
    }
}