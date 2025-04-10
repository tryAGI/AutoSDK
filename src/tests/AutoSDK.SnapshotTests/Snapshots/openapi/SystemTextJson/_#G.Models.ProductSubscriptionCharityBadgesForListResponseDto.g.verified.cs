//HintName: G.Models.ProductSubscriptionCharityBadgesForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductSubscriptionCharityBadgesForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalDonation")]
        public double? TotalDonation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("badgeAchieved")]
        public string? BadgeAchieved { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("badgeAchievedEnumId")]
        public int? BadgeAchievedEnumId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionCharityBadgesForListResponseDto" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="country"></param>
        /// <param name="totalDonation"></param>
        /// <param name="badgeAchieved"></param>
        /// <param name="badgeAchievedEnumId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductSubscriptionCharityBadgesForListResponseDto(
            string? username,
            string? country,
            double? totalDonation,
            string? badgeAchieved,
            int? badgeAchievedEnumId)
        {
            this.Username = username;
            this.Country = country;
            this.TotalDonation = totalDonation;
            this.BadgeAchieved = badgeAchieved;
            this.BadgeAchievedEnumId = badgeAchievedEnumId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionCharityBadgesForListResponseDto" /> class.
        /// </summary>
        public ProductSubscriptionCharityBadgesForListResponseDto()
        {
        }
    }
}