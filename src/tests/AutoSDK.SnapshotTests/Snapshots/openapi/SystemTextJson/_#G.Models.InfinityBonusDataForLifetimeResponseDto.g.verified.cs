//HintName: G.Models.InfinityBonusDataForLifetimeResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InfinityBonusDataForLifetimeResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifetimeBV")]
        public double? LifetimeBV { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifetimeEarning")]
        public double? LifetimeEarning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfinityBonusDataForLifetimeResponseDto" /> class.
        /// </summary>
        /// <param name="lifetimeBV"></param>
        /// <param name="lifetimeEarning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfinityBonusDataForLifetimeResponseDto(
            double? lifetimeBV,
            double? lifetimeEarning)
        {
            this.LifetimeBV = lifetimeBV;
            this.LifetimeEarning = lifetimeEarning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfinityBonusDataForLifetimeResponseDto" /> class.
        /// </summary>
        public InfinityBonusDataForLifetimeResponseDto()
        {
        }
    }
}