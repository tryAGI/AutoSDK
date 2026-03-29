//HintName: G.Models.GetUsageResponseTimeSerieResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage line item with billing details
    /// </summary>
    public sealed partial class GetUsageResponseTimeSerieResult
    {
        /// <summary>
        /// Endpoint identifier that was used (e.g., 'fal-ai/flux/dev')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// The billing unit (e.g., 'image', 'video', or a GPU/compute unit for some models)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Unit { get; set; }

        /// <summary>
        /// Quantity of usage in the specified billing unit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Quantity { get; set; }

        /// <summary>
        /// Unit price used to compute charges for this line item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UnitPrice { get; set; }

        /// <summary>
        /// Computed cost (quantity × unit_price)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// Three-letter currency code (ISO 4217, e.g., 'USD')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// Authentication method label (e.g., 'Key 1', 'Key 2', 'User token'). Only populated when 'auth_method' is included in expand parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_method")]
        public string? AuthMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseTimeSerieResult" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponseTimeSerieResult(
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
        /// Initializes a new instance of the <see cref="GetUsageResponseTimeSerieResult" /> class.
        /// </summary>
        public GetUsageResponseTimeSerieResult()
        {
        }
    }
}