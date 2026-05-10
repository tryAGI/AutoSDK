//HintName: G.Models.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminatorTypeJsonConverter))]
        public global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminator(
            global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminator" /> class.
        /// </summary>
        public ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminator()
        {
        }

    }
}