//HintName: G.Models.RankForCalculateRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankForCalculateRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankVolumeOnly")]
        public bool? RankVolumeOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankForCalculateRequestDto" /> class.
        /// </summary>
        /// <param name="rankVolumeOnly"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankForCalculateRequestDto(
            bool? rankVolumeOnly)
        {
            this.RankVolumeOnly = rankVolumeOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankForCalculateRequestDto" /> class.
        /// </summary>
        public RankForCalculateRequestDto()
        {
        }
    }
}