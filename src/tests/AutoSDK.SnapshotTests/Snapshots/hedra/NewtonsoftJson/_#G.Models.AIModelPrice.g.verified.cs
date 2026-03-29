//HintName: G.Models.AIModelPrice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AIModelPrice
    {
        /// <summary>
        /// Credit cost of the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credit_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreditCost { get; set; } = default!;

        /// <summary>
        /// Unit scaling for the cost.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit_scale", Required = global::Newtonsoft.Json.Required.Always)]
        public int UnitScale { get; set; } = default!;

        /// <summary>
        /// Billing unit of the model (e.g. 'generation', 'second', 'character').
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing_unit", Required = global::Newtonsoft.Json.Required.Always)]
        public string BillingUnit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AIModelPrice" /> class.
        /// </summary>
        /// <param name="creditCost">
        /// Credit cost of the model.
        /// </param>
        /// <param name="unitScale">
        /// Unit scaling for the cost.
        /// </param>
        /// <param name="billingUnit">
        /// Billing unit of the model (e.g. 'generation', 'second', 'character').
        /// </param>
        public AIModelPrice(
            int creditCost,
            int unitScale,
            string billingUnit)
        {
            this.CreditCost = creditCost;
            this.UnitScale = unitScale;
            this.BillingUnit = billingUnit ?? throw new global::System.ArgumentNullException(nameof(billingUnit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIModelPrice" /> class.
        /// </summary>
        public AIModelPrice()
        {
        }
    }
}