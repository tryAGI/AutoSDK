//HintName: G.Models.RunRulesSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Run rules schema.
    /// </summary>
    public sealed partial class RunRulesSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TenantId { get; set; } = default!;

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_name")]
        public string? SessionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_name")]
        public string? DatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sampling_rate", Required = global::Newtonsoft.Json.Required.Always)]
        public double SamplingRate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_filter")]
        public string? TraceFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tree_filter")]
        public string? TreeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add_to_annotation_queue_id")]
        public global::System.Guid? AddToAnnotationQueueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add_to_annotation_queue_name")]
        public string? AddToAnnotationQueueName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add_to_dataset_id")]
        public global::System.Guid? AddToDatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add_to_dataset_name")]
        public string? AddToDatasetName { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("add_to_dataset_prefer_correction")]
        public bool? AddToDatasetPreferCorrection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("corrections_dataset_id")]
        public global::System.Guid? CorrectionsDatasetId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_corrections_dataset")]
        public bool? UseCorrectionsDataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_few_shot_examples")]
        public int? NumFewShotExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluators")]
        public global::System.Collections.Generic.IList<global::G.EvaluatorTopLevel>? Evaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_evaluators")]
        public global::System.Collections.Generic.IList<global::G.CodeEvaluatorTopLevel>? CodeEvaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alerts")]
        public global::System.Collections.Generic.IList<global::G.RunRulesPagerdutyAlertSchema>? Alerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhooks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.RunRulesWebhookSchema>? Webhooks { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extend_only")]
        public bool? ExtendOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("backfill_from")]
        public global::System.DateTime? BackfillFrom { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transient")]
        public bool? Transient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluator_version", Required = global::Newtonsoft.Json.Required.Always)]
        public int EvaluatorVersion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunRulesSchema" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tenantId"></param>
        /// <param name="isEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
        /// <param name="displayName"></param>
        /// <param name="samplingRate"></param>
        /// <param name="filter"></param>
        /// <param name="traceFilter"></param>
        /// <param name="treeFilter"></param>
        /// <param name="addToAnnotationQueueId"></param>
        /// <param name="addToAnnotationQueueName"></param>
        /// <param name="addToDatasetId"></param>
        /// <param name="addToDatasetName"></param>
        /// <param name="addToDatasetPreferCorrection">
        /// Default Value: false
        /// </param>
        /// <param name="correctionsDatasetId"></param>
        /// <param name="useCorrectionsDataset">
        /// Default Value: false
        /// </param>
        /// <param name="numFewShotExamples"></param>
        /// <param name="evaluators"></param>
        /// <param name="codeEvaluators"></param>
        /// <param name="alerts"></param>
        /// <param name="webhooks"></param>
        /// <param name="extendOnly">
        /// Default Value: false
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="backfillFrom"></param>
        /// <param name="transient">
        /// Default Value: false
        /// </param>
        /// <param name="evaluatorVersion"></param>
        public RunRulesSchema(
            global::System.Guid id,
            global::System.Guid tenantId,
            string displayName,
            double samplingRate,
            global::System.Collections.Generic.IList<global::G.RunRulesWebhookSchema>? webhooks,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int evaluatorVersion,
            bool? isEnabled,
            global::System.Guid? sessionId,
            string? sessionName,
            global::System.Guid? datasetId,
            string? datasetName,
            string? filter,
            string? traceFilter,
            string? treeFilter,
            global::System.Guid? addToAnnotationQueueId,
            string? addToAnnotationQueueName,
            global::System.Guid? addToDatasetId,
            string? addToDatasetName,
            bool? addToDatasetPreferCorrection,
            global::System.Guid? correctionsDatasetId,
            bool? useCorrectionsDataset,
            int? numFewShotExamples,
            global::System.Collections.Generic.IList<global::G.EvaluatorTopLevel>? evaluators,
            global::System.Collections.Generic.IList<global::G.CodeEvaluatorTopLevel>? codeEvaluators,
            global::System.Collections.Generic.IList<global::G.RunRulesPagerdutyAlertSchema>? alerts,
            bool? extendOnly,
            global::System.DateTime? backfillFrom,
            bool? transient)
        {
            this.Id = id;
            this.TenantId = tenantId;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.SamplingRate = samplingRate;
            this.Webhooks = webhooks ?? throw new global::System.ArgumentNullException(nameof(webhooks));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.EvaluatorVersion = evaluatorVersion;
            this.IsEnabled = isEnabled;
            this.SessionId = sessionId;
            this.SessionName = sessionName;
            this.DatasetId = datasetId;
            this.DatasetName = datasetName;
            this.Filter = filter;
            this.TraceFilter = traceFilter;
            this.TreeFilter = treeFilter;
            this.AddToAnnotationQueueId = addToAnnotationQueueId;
            this.AddToAnnotationQueueName = addToAnnotationQueueName;
            this.AddToDatasetId = addToDatasetId;
            this.AddToDatasetName = addToDatasetName;
            this.AddToDatasetPreferCorrection = addToDatasetPreferCorrection;
            this.CorrectionsDatasetId = correctionsDatasetId;
            this.UseCorrectionsDataset = useCorrectionsDataset;
            this.NumFewShotExamples = numFewShotExamples;
            this.Evaluators = evaluators;
            this.CodeEvaluators = codeEvaluators;
            this.Alerts = alerts;
            this.ExtendOnly = extendOnly;
            this.BackfillFrom = backfillFrom;
            this.Transient = transient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunRulesSchema" /> class.
        /// </summary>
        public RunRulesSchema()
        {
        }
    }
}