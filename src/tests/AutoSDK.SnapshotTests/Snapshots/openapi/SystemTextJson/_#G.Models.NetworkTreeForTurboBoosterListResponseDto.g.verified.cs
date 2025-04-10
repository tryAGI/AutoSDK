//HintName: G.Models.NetworkTreeForTurboBoosterListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NetworkTreeForTurboBoosterListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generations")]
        public global::System.Collections.Generic.IList<global::G.NetworkTreeForTurboBoosterListGenerationsResponseDto>? Generations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalBonus")]
        public double? TotalBonus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeBooster")]
        public string? ActiveBooster { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("renewalDate")]
        public global::System.DateTime? RenewalDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkTreeForTurboBoosterListResponseDto" /> class.
        /// </summary>
        /// <param name="generations"></param>
        /// <param name="totalBonus"></param>
        /// <param name="activeBooster"></param>
        /// <param name="renewalDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NetworkTreeForTurboBoosterListResponseDto(
            global::System.Collections.Generic.IList<global::G.NetworkTreeForTurboBoosterListGenerationsResponseDto>? generations,
            double? totalBonus,
            string? activeBooster,
            global::System.DateTime? renewalDate)
        {
            this.Generations = generations;
            this.TotalBonus = totalBonus;
            this.ActiveBooster = activeBooster;
            this.RenewalDate = renewalDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkTreeForTurboBoosterListResponseDto" /> class.
        /// </summary>
        public NetworkTreeForTurboBoosterListResponseDto()
        {
        }
    }
}