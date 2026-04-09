//HintName: G.Models.ModelProviderConnection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelProviderConnection
    {
        /// <summary>
        /// Budget alert threshold for the given provider connection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("budget_alert_threshold")]
        public double? BudgetAlertThreshold { get; set; }

        /// <summary>
        /// Date and time the budget was last reset<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("budget_last_reset_date")]
        public global::System.DateTime? BudgetLastResetDate { get; set; }

        /// <summary>
        /// Budget limit for the model provider connection (null if unlimited)<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("budget_limit")]
        public double? BudgetLimit { get; set; }

        /// <summary>
        /// Budget reset period for the model provider connection (null if not reset)<br/>
        /// * `Monthly` - Monthly<br/>
        /// * `Yearly` - Yearly<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("budget_reset_period")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BudgetResetPeriodEnumJsonConverter))]
        public global::G.BudgetResetPeriodEnum? BudgetResetPeriod { get; set; }

        /// <summary>
        /// Tracked total budget spent for the given provider connection within the current budget period<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("budget_total_spent")]
        public double? BudgetTotalSpent { get; set; }

        /// <summary>
        /// List of available models from the provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cached_available_models")]
        public string? CachedAvailableModels { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public global::G.UserSimple CreatedBy { get; set; } = default!;

        /// <summary>
        /// Azure OpenAI deployment name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_name")]
        public string? DeploymentName { get; set; }

        /// <summary>
        /// Azure OpenAI endpoint
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Google project location
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("google_location")]
        public string? GoogleLocation { get; set; }

        /// <summary>
        /// Google project ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("google_project_id")]
        public string? GoogleProjectId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Whether the model provider connection is internal, not visible to the user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_internal")]
        public bool? IsInternal { get; set; }

        /// <summary>
        /// JSON schema for the model parameters available for the provider<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("model_params")]
        public string ModelParams { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public int? Organization { get; set; }

        /// <summary>
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
        /// * `Organization` - Organization<br/>
        /// * `User` - User<br/>
        /// * `Model` - Model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scope")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ScopeEnumJsonConverter))]
        public global::G.ScopeEnum? Scope { get; set; }

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
        /// Initializes a new instance of the <see cref="ModelProviderConnection" /> class.
        /// </summary>
        /// <param name="budgetAlertThreshold">
        /// Budget alert threshold for the given provider connection
        /// </param>
        /// <param name="budgetLastResetDate">
        /// Date and time the budget was last reset<br/>
        /// Included only in responses
        /// </param>
        /// <param name="budgetLimit">
        /// Budget limit for the model provider connection (null if unlimited)<br/>
        /// Included only in responses
        /// </param>
        /// <param name="budgetResetPeriod">
        /// Budget reset period for the model provider connection (null if not reset)<br/>
        /// * `Monthly` - Monthly<br/>
        /// * `Yearly` - Yearly<br/>
        /// Included only in responses
        /// </param>
        /// <param name="budgetTotalSpent">
        /// Tracked total budget spent for the given provider connection within the current budget period<br/>
        /// Included only in responses
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
        /// <param name="googleLocation">
        /// Google project location
        /// </param>
        /// <param name="googleProjectId">
        /// Google project ID
        /// </param>
        /// <param name="isInternal">
        /// Whether the model provider connection is internal, not visible to the user
        /// </param>
        /// <param name="organization">
        /// Included only in responses
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
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="modelParams">
        /// JSON schema for the model parameters available for the provider<br/>
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
        public ModelProviderConnection(
            double? budgetAlertThreshold,
            global::System.DateTime? budgetLastResetDate,
            double? budgetLimit,
            global::G.BudgetResetPeriodEnum? budgetResetPeriod,
            double? budgetTotalSpent,
            string? cachedAvailableModels,
            string? deploymentName,
            string? endpoint,
            string? googleLocation,
            string? googleProjectId,
            bool? isInternal,
            int? organization,
            global::G.ProviderEnum? provider,
            global::G.ScopeEnum? scope,
            global::System.DateTime createdAt = default!,
            global::G.UserSimple createdBy = default!,
            int id = default!,
            string modelParams = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.BudgetAlertThreshold = budgetAlertThreshold;
            this.BudgetLastResetDate = budgetLastResetDate;
            this.BudgetLimit = budgetLimit;
            this.BudgetResetPeriod = budgetResetPeriod;
            this.BudgetTotalSpent = budgetTotalSpent;
            this.CachedAvailableModels = cachedAvailableModels;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.DeploymentName = deploymentName;
            this.Endpoint = endpoint;
            this.GoogleLocation = googleLocation;
            this.GoogleProjectId = googleProjectId;
            this.Id = id;
            this.IsInternal = isInternal;
            this.ModelParams = modelParams;
            this.Organization = organization;
            this.Provider = provider;
            this.Scope = scope;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelProviderConnection" /> class.
        /// </summary>
        public ModelProviderConnection()
        {
        }
    }
}