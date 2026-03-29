//HintName: G.Models.ThirdPartyModelVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThirdPartyModelVersion
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// User who created Dataset<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public global::G.UserSimple CreatedBy { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public string Score { get; set; } = default!;

        /// <summary>
        /// Model name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyModelVersion" /> class.
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
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// User who created Dataset<br/>
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="score">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
        public ThirdPartyModelVersion(
            string prompt,
            string providerModelId,
            string title,
            int? modelProviderConnection,
            int? organization,
            int? parentModel,
            global::G.ProviderEnum? provider,
            global::System.DateTime createdAt = default!,
            global::G.UserSimple createdBy = default!,
            int id = default!,
            string score = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Id = id;
            this.ModelProviderConnection = modelProviderConnection;
            this.Organization = organization;
            this.ParentModel = parentModel;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Provider = provider;
            this.ProviderModelId = providerModelId ?? throw new global::System.ArgumentNullException(nameof(providerModelId));
            this.Score = score;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyModelVersion" /> class.
        /// </summary>
        public ThirdPartyModelVersion()
        {
        }
    }
}