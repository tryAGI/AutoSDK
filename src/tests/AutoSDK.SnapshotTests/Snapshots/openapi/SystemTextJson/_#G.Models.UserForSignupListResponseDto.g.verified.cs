//HintName: G.Models.UserForSignupListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForSignupListResponseDto
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
        [global::System.Text.Json.Serialization.JsonPropertyName("countryName")]
        public string? CountryName { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("packagesPurchasedAmount")]
        public double? PackagesPurchasedAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sponsorUsername")]
        public string? SponsorUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placementUserUsername")]
        public string? PlacementUserUsername { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForSignupListResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="userName"></param>
        /// <param name="email"></param>
        /// <param name="countryId"></param>
        /// <param name="countryName"></param>
        /// <param name="dateOfJoining"></param>
        /// <param name="dateOfActivation"></param>
        /// <param name="packagesPurchasedAmount"></param>
        /// <param name="sponsorUsername"></param>
        /// <param name="placementUserUsername"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForSignupListResponseDto(
            long? id,
            string? firstName,
            string? lastName,
            string? userName,
            string? email,
            long? countryId,
            string? countryName,
            global::System.DateTime? dateOfJoining,
            global::System.DateTime? dateOfActivation,
            double? packagesPurchasedAmount,
            string? sponsorUsername,
            string? placementUserUsername)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.Email = email;
            this.CountryId = countryId;
            this.CountryName = countryName;
            this.DateOfJoining = dateOfJoining;
            this.DateOfActivation = dateOfActivation;
            this.PackagesPurchasedAmount = packagesPurchasedAmount;
            this.SponsorUsername = sponsorUsername;
            this.PlacementUserUsername = placementUserUsername;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForSignupListResponseDto" /> class.
        /// </summary>
        public UserForSignupListResponseDto()
        {
        }
    }
}