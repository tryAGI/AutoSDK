//HintName: G.Models.SigstoreBundle0DsseEnvelope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SigstoreBundle0DsseEnvelope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payload")]
        public string? Payload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payloadType")]
        public string? PayloadType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signatures")]
        public global::System.Collections.Generic.IList<global::G.SigstoreBundle0DsseEnvelopeSignature>? Signatures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0DsseEnvelope" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="payloadType"></param>
        /// <param name="signatures"></param>
        public SigstoreBundle0DsseEnvelope(
            string? payload,
            string? payloadType,
            global::System.Collections.Generic.IList<global::G.SigstoreBundle0DsseEnvelopeSignature>? signatures)
        {
            this.Payload = payload;
            this.PayloadType = payloadType;
            this.Signatures = signatures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SigstoreBundle0DsseEnvelope" /> class.
        /// </summary>
        public SigstoreBundle0DsseEnvelope()
        {
        }
    }
}