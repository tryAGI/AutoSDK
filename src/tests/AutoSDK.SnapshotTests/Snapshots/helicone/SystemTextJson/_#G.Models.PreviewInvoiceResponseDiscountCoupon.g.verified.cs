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
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_off")]
        public double? AmountOff { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent_off")]
        public double? PercentOff { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewInvoiceResponseDiscountCoupon" /> class.
        /// </summary>
        /// <param name="amountOff"></param>
        /// <param name="percentOff"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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