//HintName: G.Models.GenerationsFilterSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationsFilterSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_of_generation_min")]
        public global::System.DateTime? TimeOfGenerationMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_of_generation_max")]
        public global::System.DateTime? TimeOfGenerationMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_units_min")]
        public int? TotalUnitsMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_units_max")]
        public int? TotalUnitsMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_min")]
        public double? CostMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_max")]
        public double? CostMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model")]
        public string? AiModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_token_min")]
        public int? PromptTokenMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_token_max")]
        public int? PromptTokenMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_token_min")]
        public int? CompletionTokenMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_token_max")]
        public int? CompletionTokenMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public string? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Example: openai__gpt-3.5-turbo, anthropic__claude-2.1
        /// </summary>
        /// <example>openai__gpt-3.5-turbo, anthropic__claude-2.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_org_model")]
        public string? AiOrgModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weighted_feedback_min")]
        public double? WeightedFeedbackMin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weighted_feedback_max")]
        public double? WeightedFeedbackMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtual_keys")]
        public string? VirtualKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        public string? Configs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_slug")]
        public string? WorkspaceSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_slug")]
        public string? PromptSlug { get; set; }

        /// <summary>
        /// max: 50000, default: 50000<br/>
        /// Example: 50000
        /// </summary>
        /// <example>50000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public double? PageSize { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_page")]
        public double? CurrentPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationsFilterSchema" /> class.
        /// </summary>
        /// <param name="timeOfGenerationMin"></param>
        /// <param name="timeOfGenerationMax"></param>
        /// <param name="totalUnitsMin"></param>
        /// <param name="totalUnitsMax"></param>
        /// <param name="costMin"></param>
        /// <param name="costMax"></param>
        /// <param name="aiModel"></param>
        /// <param name="promptTokenMin"></param>
        /// <param name="promptTokenMax"></param>
        /// <param name="completionTokenMin"></param>
        /// <param name="completionTokenMax"></param>
        /// <param name="statusCode"></param>
        /// <param name="metadata"></param>
        /// <param name="aiOrgModel">
        /// Example: openai__gpt-3.5-turbo, anthropic__claude-2.1
        /// </param>
        /// <param name="weightedFeedbackMin"></param>
        /// <param name="weightedFeedbackMax"></param>
        /// <param name="virtualKeys"></param>
        /// <param name="traceId"></param>
        /// <param name="configs"></param>
        /// <param name="workspaceSlug"></param>
        /// <param name="promptSlug"></param>
        /// <param name="pageSize">
        /// max: 50000, default: 50000<br/>
        /// Example: 50000
        /// </param>
        /// <param name="currentPage">
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationsFilterSchema(
            global::System.DateTime? timeOfGenerationMin,
            global::System.DateTime? timeOfGenerationMax,
            int? totalUnitsMin,
            int? totalUnitsMax,
            double? costMin,
            double? costMax,
            string? aiModel,
            int? promptTokenMin,
            int? promptTokenMax,
            int? completionTokenMin,
            int? completionTokenMax,
            string? statusCode,
            object? metadata,
            string? aiOrgModel,
            double? weightedFeedbackMin,
            double? weightedFeedbackMax,
            string? virtualKeys,
            string? traceId,
            string? configs,
            string? workspaceSlug,
            string? promptSlug,
            double? pageSize,
            double? currentPage)
        {
            this.TimeOfGenerationMin = timeOfGenerationMin;
            this.TimeOfGenerationMax = timeOfGenerationMax;
            this.TotalUnitsMin = totalUnitsMin;
            this.TotalUnitsMax = totalUnitsMax;
            this.CostMin = costMin;
            this.CostMax = costMax;
            this.AiModel = aiModel;
            this.PromptTokenMin = promptTokenMin;
            this.PromptTokenMax = promptTokenMax;
            this.CompletionTokenMin = completionTokenMin;
            this.CompletionTokenMax = completionTokenMax;
            this.StatusCode = statusCode;
            this.Metadata = metadata;
            this.AiOrgModel = aiOrgModel;
            this.WeightedFeedbackMin = weightedFeedbackMin;
            this.WeightedFeedbackMax = weightedFeedbackMax;
            this.VirtualKeys = virtualKeys;
            this.TraceId = traceId;
            this.Configs = configs;
            this.WorkspaceSlug = workspaceSlug;
            this.PromptSlug = promptSlug;
            this.PageSize = pageSize;
            this.CurrentPage = currentPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationsFilterSchema" /> class.
        /// </summary>
        public GenerationsFilterSchema()
        {
        }
    }
}