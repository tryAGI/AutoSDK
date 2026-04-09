//HintName: G.Models.CreateAzureOpenAICredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAzureOpenAICredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateAzureOpenAICredentialDTOProviderJsonConverter))]
        public global::G.CreateAzureOpenAICredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateAzureOpenAICredentialDTORegionJsonConverter))]
        public global::G.CreateAzureOpenAICredentialDTORegion Region { get; set; } = default!;

        /// <summary>
        /// Example: [gpt-4-0125-preview, gpt-4-0613]
        /// </summary>
        /// <example>[gpt-4-0125-preview, gpt-4-0613]</example>
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateAzureOpenAICredentialDTOModel> Models { get; set; } = default!;

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("openAIKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string OpenAIKey { get; set; } = default!;

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ocpApimSubscriptionKey")]
        public string? OcpApimSubscriptionKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("openAIEndpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public string OpenAIEndpoint { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="CreateAzureOpenAICredentialDTO" /> class.
        /// </summary>
        /// <param name="region"></param>
        /// <param name="models">
        /// Example: [gpt-4-0125-preview, gpt-4-0613]
        /// </param>
        /// <param name="openAIKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="openAIEndpoint"></param>
        /// <param name="provider"></param>
        /// <param name="ocpApimSubscriptionKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateAzureOpenAICredentialDTO(
            global::G.CreateAzureOpenAICredentialDTORegion region,
            global::System.Collections.Generic.IList<global::G.CreateAzureOpenAICredentialDTOModel> models,
            string openAIKey,
            string openAIEndpoint,
            global::G.CreateAzureOpenAICredentialDTOProvider provider,
            string? ocpApimSubscriptionKey,
            string? name)
        {
            this.Provider = provider;
            this.Region = region;
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.OpenAIKey = openAIKey ?? throw new global::System.ArgumentNullException(nameof(openAIKey));
            this.OcpApimSubscriptionKey = ocpApimSubscriptionKey;
            this.OpenAIEndpoint = openAIEndpoint ?? throw new global::System.ArgumentNullException(nameof(openAIEndpoint));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAzureOpenAICredentialDTO" /> class.
        /// </summary>
        public CreateAzureOpenAICredentialDTO()
        {
        }
    }
}