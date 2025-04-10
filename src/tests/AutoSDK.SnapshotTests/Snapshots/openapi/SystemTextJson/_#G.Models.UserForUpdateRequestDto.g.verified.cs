//HintName: G.Models.UserForUpdateRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForUpdateRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("btcAddress")]
        public string? BtcAddress { get; set; }

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
        /// Initializes a new instance of the <see cref="UserForUpdateRequestDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <param name="btcAddress"></param>
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
        public UserForUpdateRequestDto(
            long? id,
            string? password,
            string? confirmPassword,
            string? btcAddress,
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
            this.Password = password;
            this.ConfirmPassword = confirmPassword;
            this.BtcAddress = btcAddress;
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
        /// Initializes a new instance of the <see cref="UserForUpdateRequestDto" /> class.
        /// </summary>
        public UserForUpdateRequestDto()
        {
        }
    }
}