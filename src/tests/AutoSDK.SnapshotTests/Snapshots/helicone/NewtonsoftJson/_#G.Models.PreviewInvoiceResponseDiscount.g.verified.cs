//HintName: G.Models.PreviewInvoiceResponseDiscount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreviewInvoiceResponseDiscount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("coupon", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PreviewInvoiceResponseDiscountCoupon Coupon { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewInvoiceResponseDiscount" /> class.
        /// </summary>
        /// <param name="coupon"></param>
        public PreviewInvoiceResponseDiscount(
            global::G.PreviewInvoiceResponseDiscountCoupon coupon)
        {
            this.Coupon = coupon ?? throw new global::System.ArgumentNullException(nameof(coupon));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewInvoiceResponseDiscount" /> class.
        /// </summary>
        public PreviewInvoiceResponseDiscount()
        {
        }
    }
}