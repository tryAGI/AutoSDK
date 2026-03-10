//HintName: G.Models.TimelineCommittedEventVerification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimelineCommittedEventVerification
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verified", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Verified { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reason { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload")]
        public string? Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCommittedEventVerification" /> class.
        /// </summary>
        /// <param name="verified"></param>
        /// <param name="reason"></param>
        /// <param name="signature"></param>
        /// <param name="payload"></param>
        public TimelineCommittedEventVerification(
            bool verified,
            string reason,
            string? signature,
            string? payload)
        {
            this.Verified = verified;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Signature = signature;
            this.Payload = payload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCommittedEventVerification" /> class.
        /// </summary>
        public TimelineCommittedEventVerification()
        {
        }
    }
}