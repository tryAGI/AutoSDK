//HintName: G.Models.CreateInworldCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateInworldCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateInworldCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is the Inworld Basic (Base64) authentication token. This is not returned in the API.<br/>
        /// Example: your-base64-token-here
        /// </summary>
        /// <example>your-base64-token-here</example>
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
        /// Initializes a new instance of the <see cref="CreateInworldCredentialDTO" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// This is the Inworld Basic (Base64) authentication token. This is not returned in the API.<br/>
        /// Example: your-base64-token-here
        /// </param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateInworldCredentialDTO(
            string apiKey,
            global::G.CreateInworldCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInworldCredentialDTO" /> class.
        /// </summary>
        public CreateInworldCredentialDTO()
        {
        }
    }
}