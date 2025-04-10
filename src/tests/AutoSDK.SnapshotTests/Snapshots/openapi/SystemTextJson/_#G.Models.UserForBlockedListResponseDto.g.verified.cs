//HintName: G.Models.UserForBlockedListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForBlockedListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countryId")]
        public long? CountryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateOfJoining")]
        public global::System.DateTime? DateOfJoining { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateOfActivation")]
        public global::System.DateTime? DateOfActivation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDisabled")]
        public bool? IsDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blockRemarks")]
        public string? BlockRemarks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForBlockedListResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="userName"></param>
        /// <param name="email"></param>
        /// <param name="countryId"></param>
        /// <param name="dateOfJoining"></param>
        /// <param name="dateOfActivation"></param>
        /// <param name="isDisabled"></param>
        /// <param name="blockRemarks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForBlockedListResponseDto(
            long? id,
            string? firstName,
            string? lastName,
            string? userName,
            string? email,
            long? countryId,
            global::System.DateTime? dateOfJoining,
            global::System.DateTime? dateOfActivation,
            bool? isDisabled,
            string? blockRemarks)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.Email = email;
            this.CountryId = countryId;
            this.DateOfJoining = dateOfJoining;
            this.DateOfActivation = dateOfActivation;
            this.IsDisabled = isDisabled;
            this.BlockRemarks = blockRemarks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForBlockedListResponseDto" /> class.
        /// </summary>
        public UserForBlockedListResponseDto()
        {
        }
    }
}