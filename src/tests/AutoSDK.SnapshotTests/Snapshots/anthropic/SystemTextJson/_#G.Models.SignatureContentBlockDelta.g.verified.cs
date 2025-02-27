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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SignatureContentBlockDeltaTypeJsonConverter))]
        public global::G.SignatureContentBlockDeltaType Type { get; set; } = global::G.SignatureContentBlockDeltaType.SignatureDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureContentBlockDelta" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: signature_delta
        /// </param>
        /// <param name="signature"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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