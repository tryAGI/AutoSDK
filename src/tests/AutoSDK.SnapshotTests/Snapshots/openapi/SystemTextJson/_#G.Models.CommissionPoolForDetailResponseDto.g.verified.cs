//HintName: G.Models.CommissionPoolForDetailResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommissionPoolForDetailResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poolName")]
        public string? PoolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumeRequired")]
        public int? VolumeRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activePackageValueRequired")]
        public int? ActivePackageValueRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentageRevenueShare")]
        public double? PercentageRevenueShare { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentAchievers")]
        public int? CurrentAchievers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentEstimatedRevenue")]
        public double? CurrentEstimatedRevenue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommissionPoolForDetailResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="poolName"></param>
        /// <param name="volumeRequired"></param>
        /// <param name="activePackageValueRequired"></param>
        /// <param name="percentageRevenueShare"></param>
        /// <param name="currentAchievers"></param>
        /// <param name="currentEstimatedRevenue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommissionPoolForDetailResponseDto(
            long? id,
            string? poolName,
            int? volumeRequired,
            int? activePackageValueRequired,
            double? percentageRevenueShare,
            int? currentAchievers,
            double? currentEstimatedRevenue)
        {
            this.Id = id;
            this.PoolName = poolName;
            this.VolumeRequired = volumeRequired;
            this.ActivePackageValueRequired = activePackageValueRequired;
            this.PercentageRevenueShare = percentageRevenueShare;
            this.CurrentAchievers = currentAchievers;
            this.CurrentEstimatedRevenue = currentEstimatedRevenue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommissionPoolForDetailResponseDto" /> class.
        /// </summary>
        public CommissionPoolForDetailResponseDto()
        {
        }
    }
}