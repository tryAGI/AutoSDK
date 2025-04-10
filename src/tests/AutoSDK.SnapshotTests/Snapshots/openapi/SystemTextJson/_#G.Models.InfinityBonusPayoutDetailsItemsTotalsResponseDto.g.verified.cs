//HintName: G.Models.InfinityBonusPayoutDetailsItemsTotalsResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InfinityBonusPayoutDetailsItemsTotalsResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalBV")]
        public int? TotalBV { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalEarning")]
        public double? TotalEarning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfinityBonusPayoutDetailsItemsTotalsResponseDto" /> class.
        /// </summary>
        /// <param name="totalBV"></param>
        /// <param name="totalEarning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfinityBonusPayoutDetailsItemsTotalsResponseDto(
            int? totalBV,
            double? totalEarning)
        {
            this.TotalBV = totalBV;
            this.TotalEarning = totalEarning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfinityBonusPayoutDetailsItemsTotalsResponseDto" /> class.
        /// </summary>
        public InfinityBonusPayoutDetailsItemsTotalsResponseDto()
        {
        }
    }
}