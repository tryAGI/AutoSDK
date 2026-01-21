//HintName: G.Models.StripeBusinessInfoOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StripeBusinessInfoOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_info")]
        public global::G.StripeBusinessBillingInfo? CompanyInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tax_id")]
        public global::G.StripeTaxId? TaxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_email")]
        public string? InvoiceEmail { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_business")]
        public bool? IsBusiness { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeBusinessInfoOutput" /> class.
        /// </summary>
        /// <param name="companyInfo"></param>
        /// <param name="taxId"></param>
        /// <param name="invoiceEmail"></param>
        /// <param name="isBusiness">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StripeBusinessInfoOutput(
            global::G.StripeBusinessBillingInfo? companyInfo,
            global::G.StripeTaxId? taxId,
            string? invoiceEmail,
            bool? isBusiness)
        {
            this.CompanyInfo = companyInfo;
            this.TaxId = taxId;
            this.InvoiceEmail = invoiceEmail;
            this.IsBusiness = isBusiness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeBusinessInfoOutput" /> class.
        /// </summary>
        public StripeBusinessInfoOutput()
        {
        }
    }
}