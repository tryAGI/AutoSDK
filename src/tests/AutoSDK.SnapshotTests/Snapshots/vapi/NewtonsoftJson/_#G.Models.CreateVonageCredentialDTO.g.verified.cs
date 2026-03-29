//HintName: G.Models.CreateVonageCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVonageCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateVonageCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiSecret", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiSecret { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateVonageCredentialDTO" /> class.
        /// </summary>
        /// <param name="apiSecret">
        /// This is not returned in the API.
        /// </param>
        /// <param name="apiKey"></param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateVonageCredentialDTO(
            string apiSecret,
            string apiKey,
            global::G.CreateVonageCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.ApiSecret = apiSecret ?? throw new global::System.ArgumentNullException(nameof(apiSecret));
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVonageCredentialDTO" /> class.
        /// </summary>
        public CreateVonageCredentialDTO()
        {
        }
    }
}