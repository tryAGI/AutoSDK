//HintName: G.Models.RankSummaryResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankSummaryResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentVolumeLeft")]
        public double? CurrentVolumeLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentVolumeRight")]
        public double? CurrentVolumeRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::G.RankSummaryItemDto>? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankSummaryResponseDto" /> class.
        /// </summary>
        /// <param name="currentVolumeLeft"></param>
        /// <param name="currentVolumeRight"></param>
        /// <param name="items"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankSummaryResponseDto(
            double? currentVolumeLeft,
            double? currentVolumeRight,
            global::System.Collections.Generic.IList<global::G.RankSummaryItemDto>? items)
        {
            this.CurrentVolumeLeft = currentVolumeLeft;
            this.CurrentVolumeRight = currentVolumeRight;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankSummaryResponseDto" /> class.
        /// </summary>
        public RankSummaryResponseDto()
        {
        }
    }
}