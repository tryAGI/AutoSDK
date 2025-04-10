//HintName: G.Models.DownLineForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DownLineForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateOfJoining")]
        public global::System.DateTime? DateOfJoining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leg")]
        public string? Leg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateOfActivation")]
        public global::System.DateTime? DateOfActivation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activePackageValue")]
        public double? ActivePackageValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placementUserName")]
        public string? PlacementUserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sponsorUserName")]
        public string? SponsorUserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        public int? Level { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankName")]
        public string? RankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankAchievedDate")]
        public global::System.DateTime? RankAchievedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyVolumeLeft")]
        public double? MonthlyVolumeLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthlyVolumeRight")]
        public double? MonthlyVolumeRight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownLineForListResponseDto" /> class.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="dateOfJoining"></param>
        /// <param name="leg"></param>
        /// <param name="dateOfActivation"></param>
        /// <param name="activePackageValue"></param>
        /// <param name="placementUserName"></param>
        /// <param name="sponsorUserName"></param>
        /// <param name="level"></param>
        /// <param name="rankName"></param>
        /// <param name="rankAchievedDate"></param>
        /// <param name="monthlyVolumeLeft"></param>
        /// <param name="monthlyVolumeRight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DownLineForListResponseDto(
            string? userName,
            global::System.DateTime? dateOfJoining,
            string? leg,
            global::System.DateTime? dateOfActivation,
            double? activePackageValue,
            string? placementUserName,
            string? sponsorUserName,
            int? level,
            string? rankName,
            global::System.DateTime? rankAchievedDate,
            double? monthlyVolumeLeft,
            double? monthlyVolumeRight)
        {
            this.UserName = userName;
            this.DateOfJoining = dateOfJoining;
            this.Leg = leg;
            this.DateOfActivation = dateOfActivation;
            this.ActivePackageValue = activePackageValue;
            this.PlacementUserName = placementUserName;
            this.SponsorUserName = sponsorUserName;
            this.Level = level;
            this.RankName = rankName;
            this.RankAchievedDate = rankAchievedDate;
            this.MonthlyVolumeLeft = monthlyVolumeLeft;
            this.MonthlyVolumeRight = monthlyVolumeRight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownLineForListResponseDto" /> class.
        /// </summary>
        public DownLineForListResponseDto()
        {
        }
    }
}