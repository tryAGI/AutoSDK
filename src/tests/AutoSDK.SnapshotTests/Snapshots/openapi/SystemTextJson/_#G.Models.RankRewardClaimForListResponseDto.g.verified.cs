//HintName: G.Models.RankRewardClaimForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankRewardClaimForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countryName")]
        public string? CountryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rankName")]
        public string? RankName { get; set; }

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
        /// Initializes a new instance of the <see cref="RankRewardClaimForListResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="countryName"></param>
        /// <param name="rankName"></param>
        /// <param name="userId"></param>
        /// <param name="submittedDate"></param>
        /// <param name="rankId"></param>
        /// <param name="remark"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankRewardClaimForListResponseDto(
            long? id,
            string? username,
            string? firstName,
            string? lastName,
            string? email,
            string? countryName,
            string? rankName,
            long? userId,
            global::System.DateTime? submittedDate,
            long? rankId,
            string? remark)
        {
            this.Id = id;
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.CountryName = countryName;
            this.RankName = rankName;
            this.UserId = userId;
            this.SubmittedDate = submittedDate;
            this.RankId = rankId;
            this.Remark = remark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankRewardClaimForListResponseDto" /> class.
        /// </summary>
        public RankRewardClaimForListResponseDto()
        {
        }
    }
}