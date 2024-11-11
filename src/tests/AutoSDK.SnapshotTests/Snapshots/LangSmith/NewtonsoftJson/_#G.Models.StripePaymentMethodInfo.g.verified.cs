//HintName: G.Models.StripePaymentMethodInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Stripe customer billing info.
    /// </summary>
    public sealed partial class StripePaymentMethodInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("brand")]
        public string? Brand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last4")]
        public string? Last4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exp_month")]
        public int? ExpMonth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exp_year")]
        public int? ExpYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripePaymentMethodInfo" /> class.
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="last4"></param>
        /// <param name="expMonth"></param>
        /// <param name="expYear"></param>
        /// <param name="email"></param>
        public StripePaymentMethodInfo(
            string? brand,
            string? last4,
            int? expMonth,
            int? expYear,
            string? email)
        {
            this.Brand = brand;
            this.Last4 = last4;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripePaymentMethodInfo" /> class.
        /// </summary>
        public StripePaymentMethodInfo()
        {
        }
    }
}