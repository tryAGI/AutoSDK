//HintName: G.Models.BTCForCurrentRateResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BTCForCurrentRateResponseDto
    {
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
        /// Initializes a new instance of the <see cref="BTCForCurrentRateResponseDto" /> class.
        /// </summary>
        /// <param name="btcCurrentRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BTCForCurrentRateResponseDto(
            double? btcCurrentRate)
        {
            this.BtcCurrentRate = btcCurrentRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BTCForCurrentRateResponseDto" /> class.
        /// </summary>
        public BTCForCurrentRateResponseDto()
        {
        }
    }
}