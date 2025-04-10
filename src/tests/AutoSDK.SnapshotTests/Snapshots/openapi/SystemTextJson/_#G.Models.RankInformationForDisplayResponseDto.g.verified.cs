//HintName: G.Models.RankInformationForDisplayResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankInformationForDisplayResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankLevel")]
        public long? RankLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankName")]
        public string? RankName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextRankLevel")]
        public long? NextRankLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateAchieved")]
        public global::System.DateTime? DateAchieved { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leftLegVolumeRemaining")]
        public double? LeftLegVolumeRemaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rightLegVolumeRemaining")]
        public double? RightLegVolumeRemaining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leftLegVolumeRequired")]
        public double? LeftLegVolumeRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rightLegVolumeRequired")]
        public double? RightLegVolumeRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leftLegDownlineRankAchieved")]
        public int? LeftLegDownlineRankAchieved { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rightLegDownlineRankAchieved")]
        public int? RightLegDownlineRankAchieved { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leftLegDownlineRankRequired")]
        public int? LeftLegDownlineRankRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rightLegDownlineRankRequired")]
        public int? RightLegDownlineRankRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leftLegDownlineRanks")]
        public string? LeftLegDownlineRanks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rightLegDownlineRanks")]
        public string? RightLegDownlineRanks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leftLegDownlineRankCompleted")]
        public bool? LeftLegDownlineRankCompleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rightLegDownlineRankCompleted")]
        public bool? RightLegDownlineRankCompleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankInformationForDisplayResponseDto" /> class.
        /// </summary>
        /// <param name="rankLevel"></param>
        /// <param name="rankName"></param>
        /// <param name="nextRankLevel"></param>
        /// <param name="dateAchieved"></param>
        /// <param name="leftLegVolumeRemaining"></param>
        /// <param name="rightLegVolumeRemaining"></param>
        /// <param name="leftLegVolumeRequired"></param>
        /// <param name="rightLegVolumeRequired"></param>
        /// <param name="leftLegDownlineRankAchieved"></param>
        /// <param name="rightLegDownlineRankAchieved"></param>
        /// <param name="leftLegDownlineRankRequired"></param>
        /// <param name="rightLegDownlineRankRequired"></param>
        /// <param name="leftLegDownlineRanks"></param>
        /// <param name="rightLegDownlineRanks"></param>
        /// <param name="leftLegDownlineRankCompleted"></param>
        /// <param name="rightLegDownlineRankCompleted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankInformationForDisplayResponseDto(
            long? rankLevel,
            string? rankName,
            long? nextRankLevel,
            global::System.DateTime? dateAchieved,
            double? leftLegVolumeRemaining,
            double? rightLegVolumeRemaining,
            double? leftLegVolumeRequired,
            double? rightLegVolumeRequired,
            int? leftLegDownlineRankAchieved,
            int? rightLegDownlineRankAchieved,
            int? leftLegDownlineRankRequired,
            int? rightLegDownlineRankRequired,
            string? leftLegDownlineRanks,
            string? rightLegDownlineRanks,
            bool? leftLegDownlineRankCompleted,
            bool? rightLegDownlineRankCompleted)
        {
            this.RankLevel = rankLevel;
            this.RankName = rankName;
            this.NextRankLevel = nextRankLevel;
            this.DateAchieved = dateAchieved;
            this.LeftLegVolumeRemaining = leftLegVolumeRemaining;
            this.RightLegVolumeRemaining = rightLegVolumeRemaining;
            this.LeftLegVolumeRequired = leftLegVolumeRequired;
            this.RightLegVolumeRequired = rightLegVolumeRequired;
            this.LeftLegDownlineRankAchieved = leftLegDownlineRankAchieved;
            this.RightLegDownlineRankAchieved = rightLegDownlineRankAchieved;
            this.LeftLegDownlineRankRequired = leftLegDownlineRankRequired;
            this.RightLegDownlineRankRequired = rightLegDownlineRankRequired;
            this.LeftLegDownlineRanks = leftLegDownlineRanks;
            this.RightLegDownlineRanks = rightLegDownlineRanks;
            this.LeftLegDownlineRankCompleted = leftLegDownlineRankCompleted;
            this.RightLegDownlineRankCompleted = rightLegDownlineRankCompleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankInformationForDisplayResponseDto" /> class.
        /// </summary>
        public RankInformationForDisplayResponseDto()
        {
        }
    }
}