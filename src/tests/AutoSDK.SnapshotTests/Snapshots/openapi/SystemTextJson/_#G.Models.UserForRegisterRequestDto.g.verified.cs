//HintName: G.Models.UserForRegisterRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForRegisterRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legId")]
        public int? LegId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referralUserId")]
        public long? ReferralUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referralUserName")]
        public string? ReferralUserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmEmailAddress")]
        public string? ConfirmEmailAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmPassword")]
        public string? ConfirmPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smart")]
        public bool? Smart { get; set; }

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
        /// Initializes a new instance of the <see cref="UserForRegisterRequestDto" /> class.
        /// </summary>
        /// <param name="legId"></param>
        /// <param name="referralUserId"></param>
        /// <param name="referralUserName"></param>
        /// <param name="confirmEmailAddress"></param>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <param name="smart"></param>
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
        public UserForRegisterRequestDto(
            int? legId,
            long? referralUserId,
            string? referralUserName,
            string? confirmEmailAddress,
            string? password,
            string? confirmPassword,
            bool? smart,
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
            this.LegId = legId;
            this.ReferralUserId = referralUserId;
            this.ReferralUserName = referralUserName;
            this.ConfirmEmailAddress = confirmEmailAddress;
            this.Password = password;
            this.ConfirmPassword = confirmPassword;
            this.Smart = smart;
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
        /// Initializes a new instance of the <see cref="UserForRegisterRequestDto" /> class.
        /// </summary>
        public UserForRegisterRequestDto()
        {
        }
    }
}