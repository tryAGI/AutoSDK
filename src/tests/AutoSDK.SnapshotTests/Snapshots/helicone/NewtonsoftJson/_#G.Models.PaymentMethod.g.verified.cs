//HintName: G.Models.PaymentMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaymentMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("brand", Required = global::Newtonsoft.Json.Required.Always)]
        public string Brand { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last4", Required = global::Newtonsoft.Json.Required.Always)]
        public string Last4 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exp_month", Required = global::Newtonsoft.Json.Required.Always)]
        public double ExpMonth { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exp_year", Required = global::Newtonsoft.Json.Required.Always)]
        public double ExpYear { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="brand"></param>
        /// <param name="last4"></param>
        /// <param name="expMonth"></param>
        /// <param name="expYear"></param>
        public PaymentMethod(
            string id,
            string brand,
            string last4,
            double expMonth,
            double expYear)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Brand = brand ?? throw new global::System.ArgumentNullException(nameof(brand));
            this.Last4 = last4 ?? throw new global::System.ArgumentNullException(nameof(last4));
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        public PaymentMethod()
        {
        }
    }
}