//HintName: G.Models.CreateTwilioCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTwilioCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateTwilioCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authToken")]
        public string? AuthToken { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKey")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiSecret")]
        public string? ApiSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountSid", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccountSid { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateTwilioCredentialDTO" /> class.
        /// </summary>
        /// <param name="accountSid"></param>
        /// <param name="provider"></param>
        /// <param name="authToken">
        /// This is not returned in the API.
        /// </param>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="apiSecret">
        /// This is not returned in the API.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateTwilioCredentialDTO(
            string accountSid,
            global::G.CreateTwilioCredentialDTOProvider provider,
            string? authToken,
            string? apiKey,
            string? apiSecret,
            string? name)
        {
            this.Provider = provider;
            this.AuthToken = authToken;
            this.ApiKey = apiKey;
            this.ApiSecret = apiSecret;
            this.AccountSid = accountSid ?? throw new global::System.ArgumentNullException(nameof(accountSid));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTwilioCredentialDTO" /> class.
        /// </summary>
        public CreateTwilioCredentialDTO()
        {
        }
    }
}