//HintName: G.Models.AutoTopoffSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutoTopoffSettings
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
        [global::Newtonsoft.Json.JsonProperty("stripePaymentMethodId")]
        public string? StripePaymentMethodId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastTopoffAt")]
        public string? LastTopoffAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("consecutiveFailures", Required = global::Newtonsoft.Json.Required.Always)]
        public double ConsecutiveFailures { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTopoffSettings" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="thresholdCents"></param>
        /// <param name="topoffAmountCents"></param>
        /// <param name="consecutiveFailures"></param>
        /// <param name="stripePaymentMethodId"></param>
        /// <param name="lastTopoffAt"></param>
        public AutoTopoffSettings(
            bool enabled,
            double thresholdCents,
            double topoffAmountCents,
            double consecutiveFailures,
            string? stripePaymentMethodId,
            string? lastTopoffAt)
        {
            this.Enabled = enabled;
            this.ThresholdCents = thresholdCents;
            this.TopoffAmountCents = topoffAmountCents;
            this.StripePaymentMethodId = stripePaymentMethodId;
            this.LastTopoffAt = lastTopoffAt;
            this.ConsecutiveFailures = consecutiveFailures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTopoffSettings" /> class.
        /// </summary>
        public AutoTopoffSettings()
        {
        }
    }
}