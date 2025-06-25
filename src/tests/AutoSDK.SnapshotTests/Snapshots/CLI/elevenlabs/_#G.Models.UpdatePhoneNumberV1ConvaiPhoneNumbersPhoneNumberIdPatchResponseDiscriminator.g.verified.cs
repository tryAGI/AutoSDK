//HintName: G.Models.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminatorProviderJsonConverter))]
        public global::G.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminator(
            global::G.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminatorProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminator" /> class.
        /// </summary>
        public UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminator()
        {
        }
    }
}