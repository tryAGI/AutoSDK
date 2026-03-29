//HintName: G.Models.ModelProviderConnectionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelProviderConnectionRequest
    {
        /// <summary>
        /// Model provider API key<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Model provider Auth token<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_token")]
        public string? AuthToken { get; set; }

        /// <summary>
        /// Budget alert threshold for the given provider connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_alert_threshold")]
        public double? BudgetAlertThreshold { get; set; }

        /// <summary>
        /// List of available models from the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_available_models")]
        public string? CachedAvailableModels { get; set; }

        /// <summary>
        /// Azure OpenAI deployment name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        public string? DeploymentName { get; set; }

        /// <summary>
        /// Azure OpenAI endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// The content of GOOGLE_APPLICATION_CREDENTIALS json file<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google_application_credentials")]
        public string? GoogleApplicationCredentials { get; set; }

        /// <summary>
        /// Google project location
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google_location")]
        public string? GoogleLocation { get; set; }

        /// <summary>
        /// Google project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google_project_id")]
        public string? GoogleProjectId { get; set; }

        /// <summary>
        /// Whether the model provider connection is internal, not visible to the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_internal")]
        public bool? IsInternal { get; set; }

        /// <summary>
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
        /// * `Organization` - Organization<br/>
        /// * `User` - User<br/>
        /// * `Model` - Model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScopeEnumJsonConverter))]
        public global::G.ScopeEnum? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelProviderConnectionRequest" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Model provider API key<br/>
        /// Included only in requests
        /// </param>
        /// <param name="authToken">
        /// Model provider Auth token<br/>
        /// Included only in requests
        /// </param>
        /// <param name="budgetAlertThreshold">
        /// Budget alert threshold for the given provider connection
        /// </param>
        /// <param name="cachedAvailableModels">
        /// List of available models from the provider
        /// </param>
        /// <param name="deploymentName">
        /// Azure OpenAI deployment name
        /// </param>
        /// <param name="endpoint">
        /// Azure OpenAI endpoint
        /// </param>
        /// <param name="googleApplicationCredentials">
        /// The content of GOOGLE_APPLICATION_CREDENTIALS json file<br/>
        /// Included only in requests
        /// </param>
        /// <param name="googleLocation">
        /// Google project location
        /// </param>
        /// <param name="googleProjectId">
        /// Google project ID
        /// </param>
        /// <param name="isInternal">
        /// Whether the model provider connection is internal, not visible to the user
        /// </param>
        /// <param name="provider">
        /// * `OpenAI` - OpenAI<br/>
        /// * `AzureOpenAI` - AzureOpenAI<br/>
        /// * `AzureAIFoundry` - AzureAIFoundry<br/>
        /// * `VertexAI` - VertexAI<br/>
        /// * `Gemini` - Gemini<br/>
        /// * `Anthropic` - Anthropic<br/>
        /// * `Custom` - Custom
        /// </param>
        /// <param name="scope">
        /// * `Organization` - Organization<br/>
        /// * `User` - User<br/>
        /// * `Model` - Model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelProviderConnectionRequest(
            string? apiKey,
            string? authToken,
            double? budgetAlertThreshold,
            string? cachedAvailableModels,
            string? deploymentName,
            string? endpoint,
            string? googleApplicationCredentials,
            string? googleLocation,
            string? googleProjectId,
            bool? isInternal,
            global::G.ProviderEnum? provider,
            global::G.ScopeEnum? scope)
        {
            this.ApiKey = apiKey;
            this.AuthToken = authToken;
            this.BudgetAlertThreshold = budgetAlertThreshold;
            this.CachedAvailableModels = cachedAvailableModels;
            this.DeploymentName = deploymentName;
            this.Endpoint = endpoint;
            this.GoogleApplicationCredentials = googleApplicationCredentials;
            this.GoogleLocation = googleLocation;
            this.GoogleProjectId = googleProjectId;
            this.IsInternal = isInternal;
            this.Provider = provider;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelProviderConnectionRequest" /> class.
        /// </summary>
        public ModelProviderConnectionRequest()
        {
        }
    }
}