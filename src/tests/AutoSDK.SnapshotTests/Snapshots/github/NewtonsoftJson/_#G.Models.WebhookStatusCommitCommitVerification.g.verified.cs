//HintName: G.Models.WebhookStatusCommitCommitVerification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookStatusCommitCommitVerification
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload")]
        public string? Payload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebhookStatusCommitCommitVerificationReasonJsonConverter))]
        public global::G.WebhookStatusCommitCommitVerificationReason Reason { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verified", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Verified { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommitVerification" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="verified"></param>
        /// <param name="payload"></param>
        /// <param name="signature"></param>
        public WebhookStatusCommitCommitVerification(
            global::G.WebhookStatusCommitCommitVerificationReason reason,
            bool verified,
            string? payload,
            string? signature)
        {
            this.Payload = payload;
            this.Reason = reason;
            this.Signature = signature;
            this.Verified = verified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommitVerification" /> class.
        /// </summary>
        public WebhookStatusCommitCommitVerification()
        {
        }
    }
}