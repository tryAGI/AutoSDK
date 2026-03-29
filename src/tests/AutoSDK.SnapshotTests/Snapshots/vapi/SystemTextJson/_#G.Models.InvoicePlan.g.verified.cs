//HintName: G.Models.InvoicePlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InvoicePlan
    {
        /// <summary>
        /// This is the name of the company.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("companyName")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// This is the address of the company.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("companyAddress")]
        public string? CompanyAddress { get; set; }

        /// <summary>
        /// This is the tax ID of the company.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("companyTaxId")]
        public string? CompanyTaxId { get; set; }

        /// <summary>
        /// This is the preferred invoicing email of the company. If not specified, defaults to the subscription's email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("companyEmail")]
        public string? CompanyEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePlan" /> class.
        /// </summary>
        /// <param name="companyName">
        /// This is the name of the company.
        /// </param>
        /// <param name="companyAddress">
        /// This is the address of the company.
        /// </param>
        /// <param name="companyTaxId">
        /// This is the tax ID of the company.
        /// </param>
        /// <param name="companyEmail">
        /// This is the preferred invoicing email of the company. If not specified, defaults to the subscription's email.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvoicePlan(
            string? companyName,
            string? companyAddress,
            string? companyTaxId,
            string? companyEmail)
        {
            this.CompanyName = companyName;
            this.CompanyAddress = companyAddress;
            this.CompanyTaxId = companyTaxId;
            this.CompanyEmail = companyEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicePlan" /> class.
        /// </summary>
        public InvoicePlan()
        {
        }
    }
}