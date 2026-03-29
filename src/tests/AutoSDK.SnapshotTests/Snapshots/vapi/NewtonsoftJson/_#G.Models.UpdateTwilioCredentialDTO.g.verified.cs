//HintName: G.Models.UpdateTwilioCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTwilioCredentialDTO
    {
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
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accountSid")]
        public string? AccountSid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTwilioCredentialDTO" /> class.
        /// </summary>
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
        /// <param name="accountSid"></param>
        public UpdateTwilioCredentialDTO(
            string? authToken,
            string? apiKey,
            string? apiSecret,
            string? name,
            string? accountSid)
        {
            this.AuthToken = authToken;
            this.ApiKey = apiKey;
            this.ApiSecret = apiSecret;
            this.Name = name;
            this.AccountSid = accountSid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTwilioCredentialDTO" /> class.
        /// </summary>
        public UpdateTwilioCredentialDTO()
        {
        }
    }
}