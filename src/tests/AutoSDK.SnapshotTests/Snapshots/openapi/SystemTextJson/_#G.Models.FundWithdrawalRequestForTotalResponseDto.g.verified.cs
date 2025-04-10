//HintName: G.Models.FundWithdrawalRequestForTotalResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FundWithdrawalRequestForTotalResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public double? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btcCurrentRate")]
        public double? BtcCurrentRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FundWithdrawalRequestForTotalResponseDto" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="btcCurrentRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FundWithdrawalRequestForTotalResponseDto(
            double? total,
            double? btcCurrentRate)
        {
            this.Total = total;
            this.BtcCurrentRate = btcCurrentRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundWithdrawalRequestForTotalResponseDto" /> class.
        /// </summary>
        public FundWithdrawalRequestForTotalResponseDto()
        {
        }
    }
}