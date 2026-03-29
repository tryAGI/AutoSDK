//HintName: G.Models.CreateGoogleCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGoogleCredentialDTO
    {
        /// <summary>
        /// This is the key for Gemini in Google AI Studio. Get it from here: https://aistudio.google.com/app/apikey
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        public global::G.CreateGoogleCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
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
        /// Initializes a new instance of the <see cref="CreateGoogleCredentialDTO" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="provider">
        /// This is the key for Gemini in Google AI Studio. Get it from here: https://aistudio.google.com/app/apikey
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateGoogleCredentialDTO(
            string apiKey,
            global::G.CreateGoogleCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGoogleCredentialDTO" /> class.
        /// </summary>
        public CreateGoogleCredentialDTO()
        {
        }
    }
}