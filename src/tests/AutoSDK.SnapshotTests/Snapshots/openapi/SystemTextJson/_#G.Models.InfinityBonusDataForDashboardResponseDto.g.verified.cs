//HintName: G.Models.InfinityBonusDataForDashboardResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InfinityBonusDataForDashboardResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyBV")]
        public double? DailyBV { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyEarning")]
        public double? DailyEarning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfinityBonusDataForDashboardResponseDto" /> class.
        /// </summary>
        /// <param name="dailyBV"></param>
        /// <param name="dailyEarning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfinityBonusDataForDashboardResponseDto(
            double? dailyBV,
            double? dailyEarning)
        {
            this.DailyBV = dailyBV;
            this.DailyEarning = dailyEarning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfinityBonusDataForDashboardResponseDto" /> class.
        /// </summary>
        public InfinityBonusDataForDashboardResponseDto()
        {
        }
    }
}