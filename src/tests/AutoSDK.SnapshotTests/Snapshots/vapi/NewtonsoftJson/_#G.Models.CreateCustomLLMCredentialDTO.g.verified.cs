//HintName: G.Models.CreateCustomLLMCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCustomLLMCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateCustomLLMCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// This is the authentication plan. Currently supports OAuth2 RFC 6749. To use Bearer authentication, use apiKey
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authenticationPlan")]
        public global::G.OAuth2AuthenticationPlan? AuthenticationPlan { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomLLMCredentialDTO" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="authenticationPlan">
        /// This is the authentication plan. Currently supports OAuth2 RFC 6749. To use Bearer authentication, use apiKey
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateCustomLLMCredentialDTO(
            string apiKey,
            global::G.CreateCustomLLMCredentialDTOProvider provider,
            global::G.OAuth2AuthenticationPlan? authenticationPlan,
            string? name)
        {
            this.Provider = provider;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.AuthenticationPlan = authenticationPlan;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomLLMCredentialDTO" /> class.
        /// </summary>
        public CreateCustomLLMCredentialDTO()
        {
        }
    }
}