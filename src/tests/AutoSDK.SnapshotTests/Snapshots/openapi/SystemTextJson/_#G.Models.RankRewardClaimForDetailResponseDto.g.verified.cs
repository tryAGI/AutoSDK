//HintName: G.Models.RankRewardClaimForDetailResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankRewardClaimForDetailResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nameOfRank")]
        public string? NameOfRank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submittedDate")]
        public global::System.DateTime? SubmittedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankId")]
        public long? RankId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankRewardClaimForDetailResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nameOfRank"></param>
        /// <param name="userId"></param>
        /// <param name="submittedDate"></param>
        /// <param name="rankId"></param>
        /// <param name="remark"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankRewardClaimForDetailResponseDto(
            long? id,
            string? nameOfRank,
            long? userId,
            global::System.DateTime? submittedDate,
            long? rankId,
            string? remark)
        {
            this.Id = id;
            this.NameOfRank = nameOfRank;
            this.UserId = userId;
            this.SubmittedDate = submittedDate;
            this.RankId = rankId;
            this.Remark = remark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankRewardClaimForDetailResponseDto" /> class.
        /// </summary>
        public RankRewardClaimForDetailResponseDto()
        {
        }
    }
}