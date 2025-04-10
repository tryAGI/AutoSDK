//HintName: G.Models.Infin8UnderFundedOrderForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Infin8UnderFundedOrderForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderDateTime")]
        public global::System.DateTime? OrderDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderAmount")]
        public double? OrderAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receivedAmount")]
        public double? ReceivedAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderStatusEnumId")]
        public int? OrderStatusEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("countryId")]
        public long? CountryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderLineItems")]
        public global::System.Collections.Generic.IList<global::G.OrderLineItemDto>? OrderLineItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Infin8UnderFundedOrderForListResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="orderDateTime"></param>
        /// <param name="orderAmount"></param>
        /// <param name="receivedAmount"></param>
        /// <param name="orderStatusEnumId"></param>
        /// <param name="username"></param>
        /// <param name="userId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="countryId"></param>
        /// <param name="orderLineItems"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Infin8UnderFundedOrderForListResponseDto(
            long? id,
            global::System.DateTime? orderDateTime,
            double? orderAmount,
            double? receivedAmount,
            int? orderStatusEnumId,
            string? username,
            long? userId,
            string? firstName,
            string? lastName,
            string? email,
            long? countryId,
            global::System.Collections.Generic.IList<global::G.OrderLineItemDto>? orderLineItems)
        {
            this.Id = id;
            this.OrderDateTime = orderDateTime;
            this.OrderAmount = orderAmount;
            this.ReceivedAmount = receivedAmount;
            this.OrderStatusEnumId = orderStatusEnumId;
            this.Username = username;
            this.UserId = userId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.CountryId = countryId;
            this.OrderLineItems = orderLineItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Infin8UnderFundedOrderForListResponseDto" /> class.
        /// </summary>
        public Infin8UnderFundedOrderForListResponseDto()
        {
        }
    }
}