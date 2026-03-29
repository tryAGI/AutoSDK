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
        [global::System.Text.Json.Serialization.JsonPropertyName("credit_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreditCost { get; set; }

        /// <summary>
        /// Unit scaling for the cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_scale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UnitScale { get; set; }

        /// <summary>
        /// Billing unit of the model (e.g. 'generation', 'second', 'character').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingUnit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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