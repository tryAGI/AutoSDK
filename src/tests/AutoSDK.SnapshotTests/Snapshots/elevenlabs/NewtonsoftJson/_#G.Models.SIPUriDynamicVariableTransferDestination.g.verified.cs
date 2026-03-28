//HintName: G.Models.SIPUriDynamicVariableTransferDestination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SIPUriDynamicVariableTransferDestination
    {
        /// <summary>
        /// Default Value: sip_uri_dynamic_variable
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
        /// Initializes a new instance of the <see cref="SIPUriDynamicVariableTransferDestination" /> class.
        /// </summary>
        /// <param name="sipUri"></param>
        /// <param name="type">
        /// Default Value: sip_uri_dynamic_variable
        /// </param>
        public SIPUriDynamicVariableTransferDestination(
            string sipUri,
            string? type)
        {
            this.Type = type;
            this.SipUri = sipUri ?? throw new global::System.ArgumentNullException(nameof(sipUri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPUriDynamicVariableTransferDestination" /> class.
        /// </summary>
        public SIPUriDynamicVariableTransferDestination()
        {
        }
    }
}