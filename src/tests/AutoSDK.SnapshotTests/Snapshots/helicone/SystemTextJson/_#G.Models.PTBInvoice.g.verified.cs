//HintName: G.Models.PTBInvoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PTBInvoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripeInvoiceId")]
        public string? StripeInvoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostedInvoiceUrl")]
        public string? HostedInvoiceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amountCents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AmountCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtotalCents")]
        public double? SubtotalCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PTBInvoice" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="organizationId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="amountCents"></param>
        /// <param name="createdAt"></param>
        /// <param name="stripeInvoiceId"></param>
        /// <param name="hostedInvoiceUrl"></param>
        /// <param name="subtotalCents"></param>
        /// <param name="notes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PTBInvoice(
            string id,
            string organizationId,
            string startDate,
            string endDate,
            double amountCents,
            string createdAt,
            string? stripeInvoiceId,
            string? hostedInvoiceUrl,
            double? subtotalCents,
            string? notes)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.StripeInvoiceId = stripeInvoiceId;
            this.HostedInvoiceUrl = hostedInvoiceUrl;
            this.StartDate = startDate ?? throw new global::System.ArgumentNullException(nameof(startDate));
            this.EndDate = endDate ?? throw new global::System.ArgumentNullException(nameof(endDate));
            this.AmountCents = amountCents;
            this.SubtotalCents = subtotalCents;
            this.Notes = notes;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PTBInvoice" /> class.
        /// </summary>
        public PTBInvoice()
        {
        }
    }
}