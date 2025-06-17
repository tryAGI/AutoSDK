//HintName: G.Models.GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
        public GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminator(
            global::G.GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminatorProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminator" /> class.
        /// </summary>
        public GetPhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdGetResponseDiscriminator()
        {
        }
    }
}