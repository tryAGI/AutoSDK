//HintName: G.Models.SigstoreBundle0DsseEnvelopeSignature.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SigstoreBundle0DsseEnvelopeSignature
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sig")]
        public string? Sig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("keyid")]
        public string? Keyid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0DsseEnvelopeSignature" /> class.
        /// </summary>
        /// <param name="sig"></param>
        /// <param name="keyid"></param>
        public SigstoreBundle0DsseEnvelopeSignature(
            string? sig,
            string? keyid)
        {
            this.Sig = sig;
            this.Keyid = keyid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0DsseEnvelopeSignature" /> class.
        /// </summary>
        public SigstoreBundle0DsseEnvelopeSignature()
        {
        }
    }
}