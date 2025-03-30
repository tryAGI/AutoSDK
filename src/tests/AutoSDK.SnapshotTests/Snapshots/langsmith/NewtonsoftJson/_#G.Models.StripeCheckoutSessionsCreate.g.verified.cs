//HintName: G.Models.StripeCheckoutSessionsCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StripeCheckoutSessionsCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount_cents", Required = global::Newtonsoft.Json.Required.Always)]
        public int AmountCents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string SuccessPath { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCheckoutSessionsCreate" /> class.
        /// </summary>
        /// <param name="amountCents"></param>
        /// <param name="successPath"></param>
        public StripeCheckoutSessionsCreate(
            int amountCents,
            string successPath)
        {
            this.AmountCents = amountCents;
            this.SuccessPath = successPath ?? throw new global::System.ArgumentNullException(nameof(successPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCheckoutSessionsCreate" /> class.
        /// </summary>
        public StripeCheckoutSessionsCreate()
        {
        }
    }
}