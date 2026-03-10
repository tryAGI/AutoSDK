//HintName: G.Models.SIPUriTransferDestination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SIPUriTransferDestination
    {
        /// <summary>
        /// Default Value: sip_uri
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sip_uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string SipUri { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPUriTransferDestination" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: sip_uri
        /// </param>
        /// <param name="sipUri"></param>
        public SIPUriTransferDestination(
            string sipUri,
            string? type)
        {
            this.SipUri = sipUri ?? throw new global::System.ArgumentNullException(nameof(sipUri));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPUriTransferDestination" /> class.
        /// </summary>
        public SIPUriTransferDestination()
        {
        }
    }
}