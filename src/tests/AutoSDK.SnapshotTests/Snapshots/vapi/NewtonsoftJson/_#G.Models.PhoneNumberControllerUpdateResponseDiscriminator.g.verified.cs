//HintName: G.Models.PhoneNumberControllerUpdateResponseDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberControllerUpdateResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PhoneNumberControllerUpdateResponseDiscriminatorProviderJsonConverter))]
        public global::G.PhoneNumberControllerUpdateResponseDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberControllerUpdateResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
        public PhoneNumberControllerUpdateResponseDiscriminator(
            global::G.PhoneNumberControllerUpdateResponseDiscriminatorProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberControllerUpdateResponseDiscriminator" /> class.
        /// </summary>
        public PhoneNumberControllerUpdateResponseDiscriminator()
        {
        }
    }
}