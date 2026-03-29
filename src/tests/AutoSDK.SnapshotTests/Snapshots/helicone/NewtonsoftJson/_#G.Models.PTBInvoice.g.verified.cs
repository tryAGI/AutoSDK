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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organizationId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stripeInvoiceId")]
        public string? StripeInvoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hostedInvoiceUrl")]
        public string? HostedInvoiceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startDate", Required = global::Newtonsoft.Json.Required.Always)]
        public string StartDate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endDate", Required = global::Newtonsoft.Json.Required.Always)]
        public string EndDate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amountCents", Required = global::Newtonsoft.Json.Required.Always)]
        public double AmountCents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subtotalCents")]
        public double? SubtotalCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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