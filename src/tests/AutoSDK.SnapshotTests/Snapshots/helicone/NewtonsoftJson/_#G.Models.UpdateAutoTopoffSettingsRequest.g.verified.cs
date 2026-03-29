//HintName: G.Models.UpdateAutoTopoffSettingsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAutoTopoffSettingsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thresholdCents", Required = global::Newtonsoft.Json.Required.Always)]
        public double ThresholdCents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topoffAmountCents", Required = global::Newtonsoft.Json.Required.Always)]
        public double TopoffAmountCents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stripePaymentMethodId", Required = global::Newtonsoft.Json.Required.Always)]
        public string StripePaymentMethodId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutoTopoffSettingsRequest" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="thresholdCents"></param>
        /// <param name="topoffAmountCents"></param>
        /// <param name="stripePaymentMethodId"></param>
        public UpdateAutoTopoffSettingsRequest(
            bool enabled,
            double thresholdCents,
            double topoffAmountCents,
            string stripePaymentMethodId)
        {
            this.Enabled = enabled;
            this.ThresholdCents = thresholdCents;
            this.TopoffAmountCents = topoffAmountCents;
            this.StripePaymentMethodId = stripePaymentMethodId ?? throw new global::System.ArgumentNullException(nameof(stripePaymentMethodId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutoTopoffSettingsRequest" /> class.
        /// </summary>
        public UpdateAutoTopoffSettingsRequest()
        {
        }
    }
}