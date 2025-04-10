//HintName: G.Models.AffiliateValuesForDashboardResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AffiliateValuesForDashboardResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directBonus")]
        public double? DirectBonus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkBonus")]
        public double? NetworkBonus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leftDailyBonusValue")]
        public double? LeftDailyBonusValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rightDailyBonusValue")]
        public double? RightDailyBonusValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateValuesForDashboardResponseDto" /> class.
        /// </summary>
        /// <param name="directBonus"></param>
        /// <param name="networkBonus"></param>
        /// <param name="leftDailyBonusValue"></param>
        /// <param name="rightDailyBonusValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AffiliateValuesForDashboardResponseDto(
            double? directBonus,
            double? networkBonus,
            double? leftDailyBonusValue,
            double? rightDailyBonusValue)
        {
            this.DirectBonus = directBonus;
            this.NetworkBonus = networkBonus;
            this.LeftDailyBonusValue = leftDailyBonusValue;
            this.RightDailyBonusValue = rightDailyBonusValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AffiliateValuesForDashboardResponseDto" /> class.
        /// </summary>
        public AffiliateValuesForDashboardResponseDto()
        {
        }
    }
}