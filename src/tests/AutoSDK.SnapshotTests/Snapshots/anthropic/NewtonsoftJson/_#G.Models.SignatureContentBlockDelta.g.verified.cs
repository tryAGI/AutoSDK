//HintName: G.Models.SignatureContentBlockDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SignatureContentBlockDelta
    {
        /// <summary>
        /// Default Value: signature_delta
        /// </summary>
        /// <default>global::G.SignatureContentBlockDeltaType.SignatureDelta</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SignatureContentBlockDeltaType Type { get; set; } = global::G.SignatureContentBlockDeltaType.SignatureDelta;

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
        /// Initializes a new instance of the <see cref="SignatureContentBlockDelta" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: signature_delta
        /// </param>
        /// <param name="signature"></param>
        public SignatureContentBlockDelta(
            string signature,
            global::G.SignatureContentBlockDeltaType type = global::G.SignatureContentBlockDeltaType.SignatureDelta)
        {
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureContentBlockDelta" /> class.
        /// </summary>
        public SignatureContentBlockDelta()
        {
        }
    }
}