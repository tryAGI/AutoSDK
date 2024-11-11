//HintName: G.Models.InvoiceResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InvoiceResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount_due_cents", Required = global::Newtonsoft.Json.Required.Always)]
        public int AmountDueCents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_payment_attempt_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int NextPaymentAttemptUnix { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceResponseModel" /> class.
        /// </summary>
        /// <param name="amountDueCents"></param>
        /// <param name="nextPaymentAttemptUnix"></param>
        public InvoiceResponseModel(
            int amountDueCents,
            int nextPaymentAttemptUnix)
        {
            this.AmountDueCents = amountDueCents;
            this.NextPaymentAttemptUnix = nextPaymentAttemptUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceResponseModel" /> class.
        /// </summary>
        public InvoiceResponseModel()
        {
        }
    }
}