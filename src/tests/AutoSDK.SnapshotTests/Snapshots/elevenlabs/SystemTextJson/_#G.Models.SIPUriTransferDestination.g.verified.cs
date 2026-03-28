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
        /// Initializes a new instance of the <see cref="SIPUriTransferDestination" /> class.
        /// </summary>
        /// <param name="sipUri"></param>
        /// <param name="type">
        /// Default Value: sip_uri
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPUriTransferDestination(
            string sipUri,
            string? type)
        {
            this.Type = type;
            this.SipUri = sipUri ?? throw new global::System.ArgumentNullException(nameof(sipUri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPUriTransferDestination" /> class.
        /// </summary>
        public SIPUriTransferDestination()
        {
        }
    }
}