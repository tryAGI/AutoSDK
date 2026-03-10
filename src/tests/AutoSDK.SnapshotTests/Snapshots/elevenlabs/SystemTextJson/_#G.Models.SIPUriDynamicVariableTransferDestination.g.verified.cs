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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SipUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPUriDynamicVariableTransferDestination" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: sip_uri_dynamic_variable
        /// </param>
        /// <param name="sipUri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPUriDynamicVariableTransferDestination(
            string sipUri,
            string? type)
        {
            this.SipUri = sipUri ?? throw new global::System.ArgumentNullException(nameof(sipUri));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPUriDynamicVariableTransferDestination" /> class.
        /// </summary>
        public SIPUriDynamicVariableTransferDestination()
        {
        }
    }
}