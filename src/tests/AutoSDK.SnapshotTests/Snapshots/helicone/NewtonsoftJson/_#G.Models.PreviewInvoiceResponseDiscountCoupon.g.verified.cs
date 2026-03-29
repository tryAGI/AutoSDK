//HintName: G.Models.PreviewInvoiceResponseDiscountCoupon.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreviewInvoiceResponseDiscountCoupon
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount_off")]
        public double? AmountOff { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("percent_off")]
        public double? PercentOff { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewInvoiceResponseDiscountCoupon" /> class.
        /// </summary>
        /// <param name="amountOff"></param>
        /// <param name="percentOff"></param>
        /// <param name="name"></param>
        public PreviewInvoiceResponseDiscountCoupon(
            double? amountOff,
            double? percentOff,
            string? name)
        {
            this.AmountOff = amountOff;
            this.PercentOff = percentOff;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewInvoiceResponseDiscountCoupon" /> class.
        /// </summary>
        public PreviewInvoiceResponseDiscountCoupon()
        {
        }
    }
}