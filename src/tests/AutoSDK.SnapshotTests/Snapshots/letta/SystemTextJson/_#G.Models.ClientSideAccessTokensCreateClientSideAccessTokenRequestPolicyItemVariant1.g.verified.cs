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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1TypeJsonConverter))]
        public global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces> Access { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="access"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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