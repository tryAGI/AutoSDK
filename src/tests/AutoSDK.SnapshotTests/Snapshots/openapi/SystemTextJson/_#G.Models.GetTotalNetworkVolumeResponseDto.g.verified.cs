//HintName: G.Models.GetTotalNetworkVolumeResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTotalNetworkVolumeResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leftTotal")]
        public double? LeftTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rightTotal")]
        public double? RightTotal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTotalNetworkVolumeResponseDto" /> class.
        /// </summary>
        /// <param name="leftTotal"></param>
        /// <param name="rightTotal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTotalNetworkVolumeResponseDto(
            double? leftTotal,
            double? rightTotal)
        {
            this.LeftTotal = leftTotal;
            this.RightTotal = rightTotal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTotalNetworkVolumeResponseDto" /> class.
        /// </summary>
        public GetTotalNetworkVolumeResponseDto()
        {
        }
    }
}