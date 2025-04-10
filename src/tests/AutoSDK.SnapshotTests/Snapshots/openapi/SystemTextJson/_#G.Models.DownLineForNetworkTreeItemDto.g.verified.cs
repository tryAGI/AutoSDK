//HintName: G.Models.DownLineForNetworkTreeItemDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DownLineForNetworkTreeItemDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sponsorUserName")]
        public string? SponsorUserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyVolumeLeft")]
        public double? DailyVolumeLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyVolumeRight")]
        public double? DailyVolumeRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyCarryForwardLeft")]
        public double? DailyCarryForwardLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyCarryForwardRight")]
        public double? DailyCarryForwardRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activePackageValue")]
        public double? ActivePackageValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankId")]
        public long? RankId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uplineUserId")]
        public long? UplineUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownLineForNetworkTreeItemDto" /> class.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="sponsorUserName"></param>
        /// <param name="dailyVolumeLeft"></param>
        /// <param name="dailyVolumeRight"></param>
        /// <param name="dailyCarryForwardLeft"></param>
        /// <param name="dailyCarryForwardRight"></param>
        /// <param name="activePackageValue"></param>
        /// <param name="userId"></param>
        /// <param name="rankId"></param>
        /// <param name="uplineUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DownLineForNetworkTreeItemDto(
            string? userName,
            string? sponsorUserName,
            double? dailyVolumeLeft,
            double? dailyVolumeRight,
            double? dailyCarryForwardLeft,
            double? dailyCarryForwardRight,
            double? activePackageValue,
            long? userId,
            long? rankId,
            long? uplineUserId)
        {
            this.UserName = userName;
            this.SponsorUserName = sponsorUserName;
            this.DailyVolumeLeft = dailyVolumeLeft;
            this.DailyVolumeRight = dailyVolumeRight;
            this.DailyCarryForwardLeft = dailyCarryForwardLeft;
            this.DailyCarryForwardRight = dailyCarryForwardRight;
            this.ActivePackageValue = activePackageValue;
            this.UserId = userId;
            this.RankId = rankId;
            this.UplineUserId = uplineUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownLineForNetworkTreeItemDto" /> class.
        /// </summary>
        public DownLineForNetworkTreeItemDto()
        {
        }
    }
}