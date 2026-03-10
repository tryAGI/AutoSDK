//HintName: G.Models.Verification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Verification
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
        [global::Newtonsoft.Json.JsonProperty("payload")]
        public string? Payload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Verification" /> class.
        /// </summary>
        /// <param name="verified"></param>
        /// <param name="reason"></param>
        /// <param name="payload"></param>
        /// <param name="signature"></param>
        public Verification(
            bool verified,
            string reason,
            string? payload,
            string? signature)
        {
            this.Verified = verified;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Payload = payload;
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Verification" /> class.
        /// </summary>
        public Verification()
        {
        }
    }
}