//HintName: G.Models.UserForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<string>? Roles { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addressLine1")]
        public string? AddressLine1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countryIsoCode")]
        public string? CountryIsoCode { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xTera")]
        public bool? XTera { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForListResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sponsorUsername"></param>
        /// <param name="placementUserUsername"></param>
        /// <param name="dateOfJoining"></param>
        /// <param name="dateOfActivation"></param>
        /// <param name="roles"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="userName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="addressLine1"></param>
        /// <param name="city"></param>
        /// <param name="countryIsoCode"></param>
        /// <param name="xTera">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForListResponseDto(
            long? id,
            string? sponsorUsername,
            string? placementUserUsername,
            global::System.DateTime? dateOfJoining,
            global::System.DateTime? dateOfActivation,
            global::System.Collections.Generic.IList<string>? roles,
            string? firstName,
            string? lastName,
            string? userName,
            string? email,
            string? phoneNumber,
            string? addressLine1,
            string? city,
            string? countryIsoCode,
            bool? xTera)
        {
            this.Id = id;
            this.SponsorUsername = sponsorUsername;
            this.PlacementUserUsername = placementUserUsername;
            this.DateOfJoining = dateOfJoining;
            this.DateOfActivation = dateOfActivation;
            this.Roles = roles;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserName = userName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.AddressLine1 = addressLine1;
            this.City = city;
            this.CountryIsoCode = countryIsoCode;
            this.XTera = xTera;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForListResponseDto" /> class.
        /// </summary>
        public UserForListResponseDto()
        {
        }
    }
}