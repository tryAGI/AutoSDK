//HintName: G.Models.GetUsageResponseSummaryItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aggregate usage statistics for the entire date range
    /// </summary>
    public sealed partial class GetUsageResponseSummaryItem
    {
        /// <summary>
        /// Endpoint identifier that was used (e.g., 'fal-ai/flux/dev')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EndpointId { get; set; } = default!;

        /// <summary>
        /// The billing unit (e.g., 'image', 'video', or a GPU/compute unit for some models)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit", Required = global::Newtonsoft.Json.Required.Always)]
        public string Unit { get; set; } = default!;

        /// <summary>
        /// Quantity of usage in the specified billing unit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantity", Required = global::Newtonsoft.Json.Required.Always)]
        public double Quantity { get; set; } = default!;

        /// <summary>
        /// Unit price used to compute charges for this line item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit_price", Required = global::Newtonsoft.Json.Required.Always)]
        public double UnitPrice { get; set; } = default!;

        /// <summary>
        /// Computed cost (quantity × unit_price)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double Cost { get; set; } = default!;

        /// <summary>
        /// Three-letter currency code (ISO 4217, e.g., 'USD')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currency", Required = global::Newtonsoft.Json.Required.Always)]
        public string Currency { get; set; } = default!;

        /// <summary>
        /// Authentication method label (e.g., 'Key 1', 'Key 2', 'User token'). Only populated when 'auth_method' is included in expand parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_method")]
        public string? AuthMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSummaryItem" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// Endpoint identifier that was used (e.g., 'fal-ai/flux/dev')
        /// </param>
        /// <param name="unit">
        /// The billing unit (e.g., 'image', 'video', or a GPU/compute unit for some models)
        /// </param>
        /// <param name="quantity">
        /// Quantity of usage in the specified billing unit
        /// </param>
        /// <param name="unitPrice">
        /// Unit price used to compute charges for this line item
        /// </param>
        /// <param name="cost">
        /// Computed cost (quantity × unit_price)
        /// </param>
        /// <param name="currency">
        /// Three-letter currency code (ISO 4217, e.g., 'USD')
        /// </param>
        /// <param name="authMethod">
        /// Authentication method label (e.g., 'Key 1', 'Key 2', 'User token'). Only populated when 'auth_method' is included in expand parameter.
        /// </param>
        public GetUsageResponseSummaryItem(
            string endpointId,
            string unit,
            double quantity,
            double unitPrice,
            double cost,
            string currency,
            string? authMethod)
        {
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Unit = unit ?? throw new global::System.ArgumentNullException(nameof(unit));
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.Cost = cost;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
            this.AuthMethod = authMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseSummaryItem" /> class.
        /// </summary>
        public GetUsageResponseSummaryItem()
        {
        }
    }
}