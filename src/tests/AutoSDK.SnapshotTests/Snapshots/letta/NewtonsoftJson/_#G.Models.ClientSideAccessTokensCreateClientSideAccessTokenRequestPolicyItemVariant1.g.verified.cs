//HintName: G.Models.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1TypeJsonConverter))]
        public global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces> Access { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="access"></param>
        /// <param name="type"></param>
        public ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1(
            string id,
            global::System.Collections.Generic.IList<global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces> access,
            global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Access = access ?? throw new global::System.ArgumentNullException(nameof(access));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1" /> class.
        /// </summary>
        public ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1()
        {
        }
    }
}