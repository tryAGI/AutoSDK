//HintName: G.Models.UpdateAzureOpenAICredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAzureOpenAICredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpdateAzureOpenAICredentialDTORegionJsonConverter))]
        public global::G.UpdateAzureOpenAICredentialDTORegion? Region { get; set; }

        /// <summary>
        /// Example: [gpt-4-0125-preview, gpt-4-0613]
        /// </summary>
        /// <example>[gpt-4-0125-preview, gpt-4-0613]</example>
        [global::Newtonsoft.Json.JsonProperty("models")]
        public global::System.Collections.Generic.IList<global::G.UpdateAzureOpenAICredentialDTOModel>? Models { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("openAIKey")]
        public string? OpenAIKey { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ocpApimSubscriptionKey")]
        public string? OcpApimSubscriptionKey { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("openAIEndpoint")]
        public string? OpenAIEndpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAzureOpenAICredentialDTO" /> class.
        /// </summary>
        /// <param name="region"></param>
        /// <param name="models">
        /// Example: [gpt-4-0125-preview, gpt-4-0613]
        /// </param>
        /// <param name="openAIKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="ocpApimSubscriptionKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        /// <param name="openAIEndpoint"></param>
        public UpdateAzureOpenAICredentialDTO(
            global::G.UpdateAzureOpenAICredentialDTORegion? region,
            global::System.Collections.Generic.IList<global::G.UpdateAzureOpenAICredentialDTOModel>? models,
            string? openAIKey,
            string? ocpApimSubscriptionKey,
            string? name,
            string? openAIEndpoint)
        {
            this.Region = region;
            this.Models = models;
            this.OpenAIKey = openAIKey;
            this.OcpApimSubscriptionKey = ocpApimSubscriptionKey;
            this.Name = name;
            this.OpenAIEndpoint = openAIEndpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAzureOpenAICredentialDTO" /> class.
        /// </summary>
        public UpdateAzureOpenAICredentialDTO()
        {
        }
    }
}