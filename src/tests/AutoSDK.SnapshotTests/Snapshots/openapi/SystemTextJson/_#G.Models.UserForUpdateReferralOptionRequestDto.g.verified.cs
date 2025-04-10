//HintName: G.Models.UserForUpdateReferralOptionRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForUpdateReferralOptionRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referralOption")]
        public int? ReferralOption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForUpdateReferralOptionRequestDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="referralOption"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForUpdateReferralOptionRequestDto(
            long? id,
            int? referralOption)
        {
            this.Id = id;
            this.ReferralOption = referralOption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForUpdateReferralOptionRequestDto" /> class.
        /// </summary>
        public UserForUpdateReferralOptionRequestDto()
        {
        }
    }
}