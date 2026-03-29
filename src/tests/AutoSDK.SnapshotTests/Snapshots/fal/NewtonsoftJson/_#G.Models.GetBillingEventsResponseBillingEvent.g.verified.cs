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
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// Endpoint identifier that was used (e.g., 'fal-ai/flux/dev')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EndpointId { get; set; } = default!;

        /// <summary>
        /// Request timestamp in ISO8601 format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timestamp { get; set; } = default!;

        /// <summary>
        /// Custom billing units for this request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_units")]
        public double? OutputUnits { get; set; }

        /// <summary>
        /// Unit price for this request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit_price")]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// Discount percentage applied to this request (e.g., 10 = 10% discount)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("percent_discount")]
        public double? PercentDiscount { get; set; }

        /// <summary>
        /// Estimated cost in nano USD (1 USD = 1,000,000,000 nano USD)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost_estimate_nano_usd", Required = global::Newtonsoft.Json.Required.Always)]
        public double CostEstimateNanoUsd { get; set; } = default!;

        /// <summary>
        /// Authentication method label (e.g., 'Key 1', 'API Key', 'User token'). Only populated when 'auth_method' is included in expand parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_method")]
        public string? AuthMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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