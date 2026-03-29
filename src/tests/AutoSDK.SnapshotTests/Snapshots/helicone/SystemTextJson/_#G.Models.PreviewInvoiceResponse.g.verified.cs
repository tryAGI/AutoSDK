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
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.LLMUsage> EvaluatorsUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiments_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.LLMUsage> ExperimentsUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tax")]
        public double? Tax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtotal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Subtotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount")]
        public global::G.PreviewInvoiceResponseDiscount? Discount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        public global::G.PreviewInvoiceResponseLines? Lines { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_payment_attempt")]
        public double? NextPaymentAttempt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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