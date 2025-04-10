//HintName: G.Models.OrderForInvoiceResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrderForInvoiceResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderId")]
        public long? OrderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datePlaced")]
        public global::System.DateTime? DatePlaced { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public double? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::G.OrderForInvoiceItemDto>? Items { get; set; }

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
        /// Initializes a new instance of the <see cref="OrderForInvoiceResponseDto" /> class.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="orderId"></param>
        /// <param name="datePlaced"></param>
        /// <param name="total"></param>
        /// <param name="items"></param>
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
        public OrderForInvoiceResponseDto(
            string? country,
            long? orderId,
            global::System.DateTime? datePlaced,
            double? total,
            global::System.Collections.Generic.IList<global::G.OrderForInvoiceItemDto>? items,
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
            this.Country = country;
            this.OrderId = orderId;
            this.DatePlaced = datePlaced;
            this.Total = total;
            this.Items = items;
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
        /// Initializes a new instance of the <see cref="OrderForInvoiceResponseDto" /> class.
        /// </summary>
        public OrderForInvoiceResponseDto()
        {
        }
    }
}