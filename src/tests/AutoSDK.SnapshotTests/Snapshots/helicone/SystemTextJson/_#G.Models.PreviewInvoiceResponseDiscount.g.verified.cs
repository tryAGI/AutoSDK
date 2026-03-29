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
        [global::System.Text.Json.Serialization.JsonPropertyName("coupon")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PreviewInvoiceResponseDiscountCoupon Coupon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewInvoiceResponseDiscount" /> class.
        /// </summary>
        /// <param name="coupon"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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