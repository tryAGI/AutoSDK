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
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

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
        public global::G.ProviderEnum? Provider { get; set; }

        /// <summary>
        /// The model ID to use within the given provider, e.g. gpt-3.5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_model_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderModelId { get; set; } = default!;

        /// <summary>
        /// Model name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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