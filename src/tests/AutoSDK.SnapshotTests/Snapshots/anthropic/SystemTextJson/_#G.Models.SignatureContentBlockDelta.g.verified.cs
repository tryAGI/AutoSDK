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
        /// <param name="signature"></param>
        /// <param name="type">
        /// Default Value: signature_delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignatureContentBlockDelta(
            string signature,
            global::G.SignatureContentBlockDeltaType type = global::G.SignatureContentBlockDeltaType.SignatureDelta)
        {
            this.Type = type;
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureContentBlockDelta" /> class.
        /// </summary>
        public SignatureContentBlockDelta()
        {
        }

        /// <summary>
        /// Creates a new <see cref="SignatureContentBlockDelta"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static SignatureContentBlockDelta FromSignature(string signature)
        {
            return new SignatureContentBlockDelta
            {
                Signature = signature,
            };
        }

    }
}