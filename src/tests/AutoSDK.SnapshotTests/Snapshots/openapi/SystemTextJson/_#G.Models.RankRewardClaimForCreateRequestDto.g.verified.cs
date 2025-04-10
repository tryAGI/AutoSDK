//HintName: G.Models.RankRewardClaimForCreateRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankRewardClaimForCreateRequestDto
    {
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
        /// Initializes a new instance of the <see cref="RankRewardClaimForCreateRequestDto" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="submittedDate"></param>
        /// <param name="rankId"></param>
        /// <param name="remark"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankRewardClaimForCreateRequestDto(
            long? userId,
            global::System.DateTime? submittedDate,
            long? rankId,
            string? remark)
        {
            this.UserId = userId;
            this.SubmittedDate = submittedDate;
            this.RankId = rankId;
            this.Remark = remark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankRewardClaimForCreateRequestDto" /> class.
        /// </summary>
        public RankRewardClaimForCreateRequestDto()
        {
        }
    }
}