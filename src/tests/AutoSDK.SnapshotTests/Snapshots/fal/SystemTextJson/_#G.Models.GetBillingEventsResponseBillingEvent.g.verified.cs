//HintName: G.Models.GetBillingEventsResponseBillingEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Individual billing event record with details
    /// </summary>
    public sealed partial class GetBillingEventsResponseBillingEvent
    {
        /// <summary>
        /// Unique identifier for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Endpoint identifier that was used (e.g., 'fal-ai/flux/dev')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Request timestamp in ISO8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Custom billing units for this request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_units")]
        public double? OutputUnits { get; set; }

        /// <summary>
        /// Unit price for this request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_price")]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// Discount percentage applied to this request (e.g., 10 = 10% discount)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent_discount")]
        public double? PercentDiscount { get; set; }

        /// <summary>
        /// Estimated cost in nano USD (1 USD = 1,000,000,000 nano USD)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_estimate_nano_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CostEstimateNanoUsd { get; set; }

        /// <summary>
        /// Authentication method label (e.g., 'Key 1', 'API Key', 'User token'). Only populated when 'auth_method' is included in expand parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_method")]
        public string? AuthMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBillingEventsResponseBillingEvent" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier that was used (e.g., 'fal-ai/flux/dev')
        /// </param>
        /// <param name="timestamp">
        /// Request timestamp in ISO8601 format
        /// </param>
        /// <param name="costEstimateNanoUsd">
        /// Estimated cost in nano USD (1 USD = 1,000,000,000 nano USD)
        /// </param>
        /// <param name="outputUnits">
        /// Custom billing units for this request
        /// </param>
        /// <param name="unitPrice">
        /// Unit price for this request
        /// </param>
        /// <param name="percentDiscount">
        /// Discount percentage applied to this request (e.g., 10 = 10% discount)
        /// </param>
        /// <param name="authMethod">
        /// Authentication method label (e.g., 'Key 1', 'API Key', 'User token'). Only populated when 'auth_method' is included in expand parameter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBillingEventsResponseBillingEvent(
            string requestId,
            string endpointId,
            string timestamp,
            double costEstimateNanoUsd,
            double? outputUnits,
            double? unitPrice,
            double? percentDiscount,
            string? authMethod)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.OutputUnits = outputUnits;
            this.UnitPrice = unitPrice;
            this.PercentDiscount = percentDiscount;
            this.CostEstimateNanoUsd = costEstimateNanoUsd;
            this.AuthMethod = authMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBillingEventsResponseBillingEvent" /> class.
        /// </summary>
        public GetBillingEventsResponseBillingEvent()
        {
        }
    }
}