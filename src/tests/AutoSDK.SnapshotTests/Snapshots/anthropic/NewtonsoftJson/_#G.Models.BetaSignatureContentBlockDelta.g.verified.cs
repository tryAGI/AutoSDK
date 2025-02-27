//HintName: G.Models.BetaSignatureContentBlockDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaSignatureContentBlockDelta
    {
        /// <summary>
        /// Default Value: signature_delta
        /// </summary>
        /// <default>global::G.BetaSignatureContentBlockDeltaType.SignatureDelta</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaSignatureContentBlockDeltaType Type { get; set; } = global::G.BetaSignatureContentBlockDeltaType.SignatureDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature", Required = global::Newtonsoft.Json.Required.Always)]
        public string Signature { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSignatureContentBlockDelta" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: signature_delta
        /// </param>
        /// <param name="signature"></param>
        public BetaSignatureContentBlockDelta(
            string signature,
            global::G.BetaSignatureContentBlockDeltaType type = global::G.BetaSignatureContentBlockDeltaType.SignatureDelta)
        {
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSignatureContentBlockDelta" /> class.
        /// </summary>
        public BetaSignatureContentBlockDelta()
        {
        }
    }
}