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
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thresholdCents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ThresholdCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topoffAmountCents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TopoffAmountCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripePaymentMethodId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StripePaymentMethodId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutoTopoffSettingsRequest" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="thresholdCents"></param>
        /// <param name="topoffAmountCents"></param>
        /// <param name="stripePaymentMethodId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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