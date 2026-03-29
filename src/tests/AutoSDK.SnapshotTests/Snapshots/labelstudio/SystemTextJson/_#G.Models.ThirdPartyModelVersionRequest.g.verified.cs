//HintName: G.Models.ThirdPartyModelVersionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThirdPartyModelVersionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_provider_connection")]
        public int? ModelProviderConnection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// Parent model interface ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_model")]
        public int? ParentModel { get; set; }

        /// <summary>
        /// Prompt to execute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The model provider to use e.g. OpenAI<br/>
        /// * `OpenAI` - OpenAI<br/>
        /// * `AzureOpenAI` - AzureOpenAI<br/>
        /// * `AzureAIFoundry` - AzureAIFoundry<br/>
        /// * `VertexAI` - VertexAI<br/>
        /// * `Gemini` - Gemini<br/>
        /// * `Anthropic` - Anthropic<br/>
        /// * `Custom` - Custom
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProviderEnumJsonConverter))]
        public global::G.ProviderEnum? Provider { get; set; }

        /// <summary>
        /// The model ID to use within the given provider, e.g. gpt-3.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderModelId { get; set; }

        /// <summary>
        /// Model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyModelVersionRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Prompt to execute
        /// </param>
        /// <param name="providerModelId">
        /// The model ID to use within the given provider, e.g. gpt-3.5
        /// </param>
        /// <param name="title">
        /// Model name
        /// </param>
        /// <param name="modelProviderConnection"></param>
        /// <param name="organization"></param>
        /// <param name="parentModel">
        /// Parent model interface ID
        /// </param>
        /// <param name="provider">
        /// The model provider to use e.g. OpenAI<br/>
        /// * `OpenAI` - OpenAI<br/>
        /// * `AzureOpenAI` - AzureOpenAI<br/>
        /// * `AzureAIFoundry` - AzureAIFoundry<br/>
        /// * `VertexAI` - VertexAI<br/>
        /// * `Gemini` - Gemini<br/>
        /// * `Anthropic` - Anthropic<br/>
        /// * `Custom` - Custom
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThirdPartyModelVersionRequest(
            string prompt,
            string providerModelId,
            string title,
            int? modelProviderConnection,
            int? organization,
            int? parentModel,
            global::G.ProviderEnum? provider)
        {
            this.ModelProviderConnection = modelProviderConnection;
            this.Organization = organization;
            this.ParentModel = parentModel;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Provider = provider;
            this.ProviderModelId = providerModelId ?? throw new global::System.ArgumentNullException(nameof(providerModelId));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyModelVersionRequest" /> class.
        /// </summary>
        public ThirdPartyModelVersionRequest()
        {
        }
    }
}