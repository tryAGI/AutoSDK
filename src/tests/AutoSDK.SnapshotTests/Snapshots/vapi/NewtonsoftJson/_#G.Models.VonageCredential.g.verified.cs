//HintName: G.Models.VonageCredential.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VonageCredential
    {
        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vonageApplicationPrivateKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string VonageApplicationPrivateKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VonageCredentialProviderJsonConverter))]
        public global::G.VonageCredentialProvider Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiSecret", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiSecret { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the credential.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the org that this credential belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// This is the Vonage Application ID for the credential.<br/>
        /// Only relevant for Vonage credentials.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vonageApplicationId", Required = global::Newtonsoft.Json.Required.Always)]
        public string VonageApplicationId { get; set; } = default!;

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VonageCredential" /> class.
        /// </summary>
        /// <param name="vonageApplicationPrivateKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="apiSecret">
        /// This is not returned in the API.
        /// </param>
        /// <param name="id">
        /// This is the unique identifier for the credential.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this credential belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </param>
        /// <param name="vonageApplicationId">
        /// This is the Vonage Application ID for the credential.<br/>
        /// Only relevant for Vonage credentials.
        /// </param>
        /// <param name="apiKey"></param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public VonageCredential(
            string vonageApplicationPrivateKey,
            string apiSecret,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string vonageApplicationId,
            string apiKey,
            global::G.VonageCredentialProvider provider,
            string? name)
        {
            this.VonageApplicationPrivateKey = vonageApplicationPrivateKey ?? throw new global::System.ArgumentNullException(nameof(vonageApplicationPrivateKey));
            this.Provider = provider;
            this.ApiSecret = apiSecret ?? throw new global::System.ArgumentNullException(nameof(apiSecret));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.VonageApplicationId = vonageApplicationId ?? throw new global::System.ArgumentNullException(nameof(vonageApplicationId));
            this.Name = name;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VonageCredential" /> class.
        /// </summary>
        public VonageCredential()
        {
        }
    }
}