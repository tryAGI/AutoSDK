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
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateAzureOpenAICredentialDTOProviderJsonConverter))]
        public global::G.CreateAzureOpenAICredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateAzureOpenAICredentialDTORegionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateAzureOpenAICredentialDTORegion Region { get; set; }

        /// <summary>
        /// Example: [gpt-4-0125-preview, gpt-4-0613]
        /// </summary>
        /// <example>[gpt-4-0125-preview, gpt-4-0613]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreateAzureOpenAICredentialDTOModel> Models { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openAIKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OpenAIKey { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocpApimSubscriptionKey")]
        public string? OcpApimSubscriptionKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openAIEndpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OpenAIEndpoint { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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