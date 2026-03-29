//HintName: G.Models.PreviewInvoiceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreviewInvoiceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluators_usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LLMUsage> EvaluatorsUsage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiments_usage", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LLMUsage> ExperimentsUsage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public double Total { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tax")]
        public double? Tax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subtotal", Required = global::Newtonsoft.Json.Required.Always)]
        public double Subtotal { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("discount")]
        public global::G.PreviewInvoiceResponseDiscount? Discount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lines")]
        public global::G.PreviewInvoiceResponseLines? Lines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_payment_attempt")]
        public double? NextPaymentAttempt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewInvoiceResponse" /> class.
        /// </summary>
        /// <param name="evaluatorsUsage"></param>
        /// <param name="experimentsUsage"></param>
        /// <param name="total"></param>
        /// <param name="subtotal"></param>
        /// <param name="tax"></param>
        /// <param name="discount"></param>
        /// <param name="lines"></param>
        /// <param name="nextPaymentAttempt"></param>
        /// <param name="currency"></param>
        public PreviewInvoiceResponse(
            global::System.Collections.Generic.IList<global::G.LLMUsage> evaluatorsUsage,
            global::System.Collections.Generic.IList<global::G.LLMUsage> experimentsUsage,
            double total,
            double subtotal,
            double? tax,
            global::G.PreviewInvoiceResponseDiscount? discount,
            global::G.PreviewInvoiceResponseLines? lines,
            double? nextPaymentAttempt,
            string? currency)
        {
            this.EvaluatorsUsage = evaluatorsUsage ?? throw new global::System.ArgumentNullException(nameof(evaluatorsUsage));
            this.ExperimentsUsage = experimentsUsage ?? throw new global::System.ArgumentNullException(nameof(experimentsUsage));
            this.Total = total;
            this.Tax = tax;
            this.Subtotal = subtotal;
            this.Discount = discount;
            this.Lines = lines;
            this.NextPaymentAttempt = nextPaymentAttempt;
            this.Currency = currency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewInvoiceResponse" /> class.
        /// </summary>
        public PreviewInvoiceResponse()
        {
        }
    }
}