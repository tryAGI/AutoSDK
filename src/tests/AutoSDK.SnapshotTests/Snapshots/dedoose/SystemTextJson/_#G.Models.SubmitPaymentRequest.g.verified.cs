//HintName: G.Models.SubmitPaymentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitPaymentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Zip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cardType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CardType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cardNum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CardNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cardCCV")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CardCCV { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expMonth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpMonth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expYear")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saveAsReoccuring")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SaveAsReoccuring { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitPaymentRequest" /> class.
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="amount"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address1"></param>
        /// <param name="address2"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="country"></param>
        /// <param name="zip"></param>
        /// <param name="cardType"></param>
        /// <param name="cardNum"></param>
        /// <param name="cardCCV"></param>
        /// <param name="expMonth"></param>
        /// <param name="expYear"></param>
        /// <param name="saveAsReoccuring"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitPaymentRequest(
            global::System.Guid accountId,
            double amount,
            string firstName,
            string lastName,
            string address1,
            string address2,
            string city,
            string state,
            string country,
            string zip,
            int cardType,
            string cardNum,
            string cardCCV,
            int expMonth,
            int expYear,
            bool saveAsReoccuring)
        {
            this.AccountId = accountId;
            this.Amount = amount;
            this.FirstName = firstName ?? throw new global::System.ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new global::System.ArgumentNullException(nameof(lastName));
            this.Address1 = address1 ?? throw new global::System.ArgumentNullException(nameof(address1));
            this.Address2 = address2 ?? throw new global::System.ArgumentNullException(nameof(address2));
            this.City = city ?? throw new global::System.ArgumentNullException(nameof(city));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
            this.Zip = zip ?? throw new global::System.ArgumentNullException(nameof(zip));
            this.CardType = cardType;
            this.CardNum = cardNum ?? throw new global::System.ArgumentNullException(nameof(cardNum));
            this.CardCCV = cardCCV ?? throw new global::System.ArgumentNullException(nameof(cardCCV));
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.SaveAsReoccuring = saveAsReoccuring;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitPaymentRequest" /> class.
        /// </summary>
        public SubmitPaymentRequest()
        {
        }
    }
}