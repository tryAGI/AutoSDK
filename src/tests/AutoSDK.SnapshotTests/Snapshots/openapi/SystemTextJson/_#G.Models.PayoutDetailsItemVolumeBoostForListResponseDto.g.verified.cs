//HintName: G.Models.PayoutDetailsItemVolumeBoostForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PayoutDetailsItemVolumeBoostForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payoutPeriodId")]
        public long? PayoutPeriodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leg1Volume")]
        public double? Leg1Volume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leg2Volume")]
        public double? Leg2Volume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applyUpLine")]
        public bool? ApplyUpLine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutDetailsItemVolumeBoostForListResponseDto" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="country"></param>
        /// <param name="userId"></param>
        /// <param name="payoutPeriodId"></param>
        /// <param name="leg1Volume"></param>
        /// <param name="leg2Volume"></param>
        /// <param name="applyUpLine"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PayoutDetailsItemVolumeBoostForListResponseDto(
            string? username,
            string? country,
            long? userId,
            long? payoutPeriodId,
            double? leg1Volume,
            double? leg2Volume,
            bool? applyUpLine)
        {
            this.Username = username;
            this.Country = country;
            this.UserId = userId;
            this.PayoutPeriodId = payoutPeriodId;
            this.Leg1Volume = leg1Volume;
            this.Leg2Volume = leg2Volume;
            this.ApplyUpLine = applyUpLine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutDetailsItemVolumeBoostForListResponseDto" /> class.
        /// </summary>
        public PayoutDetailsItemVolumeBoostForListResponseDto()
        {
        }
    }
}