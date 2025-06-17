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
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
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