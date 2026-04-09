//HintName: G.Models.PatchedThirdPartyModelVersionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedThirdPartyModelVersionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_provider_connection")]
        public int? ModelProviderConnection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// Parent model interface ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_model")]
        public int? ParentModel { get; set; }

        /// <summary>
        /// Prompt to execute
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProviderEnumJsonConverter))]
        public global::G.ProviderEnum? Provider { get; set; }

        /// <summary>
        /// The model ID to use within the given provider, e.g. gpt-3.5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_model_id")]
        public string? ProviderModelId { get; set; }

        /// <summary>
        /// Model name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedThirdPartyModelVersionRequest" /> class.
        /// </summary>
        /// <param name="modelProviderConnection"></param>
        /// <param name="organization"></param>
        /// <param name="parentModel">
        /// Parent model interface ID
        /// </param>
        /// <param name="prompt">
        /// Prompt to execute
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
        /// <param name="providerModelId">
        /// The model ID to use within the given provider, e.g. gpt-3.5
        /// </param>
        /// <param name="title">
        /// Model name
        /// </param>
        public PatchedThirdPartyModelVersionRequest(
            int? modelProviderConnection,
            int? organization,
            int? parentModel,
            string? prompt,
            global::G.ProviderEnum? provider,
            string? providerModelId,
            string? title)
        {
            this.ModelProviderConnection = modelProviderConnection;
            this.Organization = organization;
            this.ParentModel = parentModel;
            this.Prompt = prompt;
            this.Provider = provider;
            this.ProviderModelId = providerModelId;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedThirdPartyModelVersionRequest" /> class.
        /// </summary>
        public PatchedThirdPartyModelVersionRequest()
        {
        }
    }
}