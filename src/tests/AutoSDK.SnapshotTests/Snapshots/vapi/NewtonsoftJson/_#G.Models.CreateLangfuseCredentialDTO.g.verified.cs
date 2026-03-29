//HintName: G.Models.CreateLangfuseCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLangfuseCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateLangfuseCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// The public key for Langfuse project. Eg: pk-lf-...
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publicKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string PublicKey { get; set; } = default!;

        /// <summary>
        /// The secret key for Langfuse project. Eg: sk-lf-... .This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// The host URL for Langfuse project. Eg: https://cloud.langfuse.com
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiUrl { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateLangfuseCredentialDTO" /> class.
        /// </summary>
        /// <param name="publicKey">
        /// The public key for Langfuse project. Eg: pk-lf-...
        /// </param>
        /// <param name="apiKey">
        /// The secret key for Langfuse project. Eg: sk-lf-... .This is not returned in the API.
        /// </param>
        /// <param name="apiUrl">
        /// The host URL for Langfuse project. Eg: https://cloud.langfuse.com
        /// </param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateLangfuseCredentialDTO(
            string publicKey,
            string apiKey,
            string apiUrl,
            global::G.CreateLangfuseCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.PublicKey = publicKey ?? throw new global::System.ArgumentNullException(nameof(publicKey));
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.ApiUrl = apiUrl ?? throw new global::System.ArgumentNullException(nameof(apiUrl));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLangfuseCredentialDTO" /> class.
        /// </summary>
        public CreateLangfuseCredentialDTO()
        {
        }
    }
}