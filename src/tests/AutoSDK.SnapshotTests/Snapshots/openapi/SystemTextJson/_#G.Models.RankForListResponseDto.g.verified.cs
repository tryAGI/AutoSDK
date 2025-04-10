//HintName: G.Models.RankForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weakSideRequiredVolume")]
        public double? WeakSideRequiredVolume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strongSideRequiredVolume")]
        public double? StrongSideRequiredVolume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leftLegDownLineRankIdRequired")]
        public long? LeftLegDownLineRankIdRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rightLegDownLineRankIdRequired")]
        public long? RightLegDownLineRankIdRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leftLegDownLineRequiredRankQuantity")]
        public long? LeftLegDownLineRequiredRankQuantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rightLegDownLineRequiredRankQuantity")]
        public long? RightLegDownLineRequiredRankQuantity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankForListResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="weakSideRequiredVolume"></param>
        /// <param name="strongSideRequiredVolume"></param>
        /// <param name="leftLegDownLineRankIdRequired"></param>
        /// <param name="rightLegDownLineRankIdRequired"></param>
        /// <param name="leftLegDownLineRequiredRankQuantity"></param>
        /// <param name="rightLegDownLineRequiredRankQuantity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankForListResponseDto(
            long? id,
            string? name,
            double? weakSideRequiredVolume,
            double? strongSideRequiredVolume,
            long? leftLegDownLineRankIdRequired,
            long? rightLegDownLineRankIdRequired,
            long? leftLegDownLineRequiredRankQuantity,
            long? rightLegDownLineRequiredRankQuantity)
        {
            this.Id = id;
            this.Name = name;
            this.WeakSideRequiredVolume = weakSideRequiredVolume;
            this.StrongSideRequiredVolume = strongSideRequiredVolume;
            this.LeftLegDownLineRankIdRequired = leftLegDownLineRankIdRequired;
            this.RightLegDownLineRankIdRequired = rightLegDownLineRankIdRequired;
            this.LeftLegDownLineRequiredRankQuantity = leftLegDownLineRequiredRankQuantity;
            this.RightLegDownLineRequiredRankQuantity = rightLegDownLineRequiredRankQuantity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankForListResponseDto" /> class.
        /// </summary>
        public RankForListResponseDto()
        {
        }
    }
}