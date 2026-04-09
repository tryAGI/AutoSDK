//HintName: G.Models.CreatePlayHTCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePlayHTCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreatePlayHTCredentialDTOProviderJsonConverter))]
        public global::G.CreatePlayHTCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreatePlayHTCredentialDTO" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="userId"></param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreatePlayHTCredentialDTO(
            string apiKey,
            string userId,
            global::G.CreatePlayHTCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlayHTCredentialDTO" /> class.
        /// </summary>
        public CreatePlayHTCredentialDTO()
        {
        }
    }
}