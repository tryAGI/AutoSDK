//HintName: G.Models.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
        public ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminator(
            global::G.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminator" /> class.
        /// </summary>
        public ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminator()
        {
        }
    }
}