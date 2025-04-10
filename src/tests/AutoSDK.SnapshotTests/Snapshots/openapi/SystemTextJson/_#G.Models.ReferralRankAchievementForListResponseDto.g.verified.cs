//HintName: G.Models.ReferralRankAchievementForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReferralRankAchievementForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referralUserName")]
        public string? ReferralUserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referralUserId")]
        public long? ReferralUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referredUsername")]
        public string? ReferredUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateOfJoining")]
        public global::System.DateTime? DateOfJoining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("achievedDate")]
        public global::System.DateTime? AchievedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateOfActivation")]
        public global::System.DateTime? DateOfActivation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankName")]
        public string? RankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankId")]
        public long? RankId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferralRankAchievementForListResponseDto" /> class.
        /// </summary>
        /// <param name="referralUserName"></param>
        /// <param name="referralUserId"></param>
        /// <param name="referredUsername"></param>
        /// <param name="dateOfJoining"></param>
        /// <param name="achievedDate"></param>
        /// <param name="dateOfActivation"></param>
        /// <param name="rankName"></param>
        /// <param name="rankId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReferralRankAchievementForListResponseDto(
            string? referralUserName,
            long? referralUserId,
            string? referredUsername,
            global::System.DateTime? dateOfJoining,
            global::System.DateTime? achievedDate,
            global::System.DateTime? dateOfActivation,
            string? rankName,
            long? rankId)
        {
            this.ReferralUserName = referralUserName;
            this.ReferralUserId = referralUserId;
            this.ReferredUsername = referredUsername;
            this.DateOfJoining = dateOfJoining;
            this.AchievedDate = achievedDate;
            this.DateOfActivation = dateOfActivation;
            this.RankName = rankName;
            this.RankId = rankId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferralRankAchievementForListResponseDto" /> class.
        /// </summary>
        public ReferralRankAchievementForListResponseDto()
        {
        }
    }
}