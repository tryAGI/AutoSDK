//HintName: G.Models.SubmitCurrentAccountPaymentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitCurrentAccountPaymentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount", Required = global::Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("firstName", Required = global::Newtonsoft.Json.Required.Always)]
        public string FirstName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastName", Required = global::Newtonsoft.Json.Required.Always)]
        public string LastName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("address1", Required = global::Newtonsoft.Json.Required.Always)]
        public string Address1 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("address2", Required = global::Newtonsoft.Json.Required.Always)]
        public string Address2 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("city", Required = global::Newtonsoft.Json.Required.Always)]
        public string City { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country", Required = global::Newtonsoft.Json.Required.Always)]
        public string Country { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("zip", Required = global::Newtonsoft.Json.Required.Always)]
        public string Zip { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cardType", Required = global::Newtonsoft.Json.Required.Always)]
        public int CardType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cardNum", Required = global::Newtonsoft.Json.Required.Always)]
        public string CardNum { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cardCCV", Required = global::Newtonsoft.Json.Required.Always)]
        public string CardCCV { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expMonth", Required = global::Newtonsoft.Json.Required.Always)]
        public int ExpMonth { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expYear", Required = global::Newtonsoft.Json.Required.Always)]
        public int ExpYear { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("saveAsReoccuring", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SaveAsReoccuring { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitCurrentAccountPaymentRequest" /> class.
        /// </summary>
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
        public SubmitCurrentAccountPaymentRequest(
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
        /// Initializes a new instance of the <see cref="SubmitCurrentAccountPaymentRequest" /> class.
        /// </summary>
        public SubmitCurrentAccountPaymentRequest()
        {
        }
    }
}