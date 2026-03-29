//HintName: G.Models.CallQA.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallQA
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_qa_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallQaId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cohort_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CohortId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cohort_version", Required = global::Newtonsoft.Json.Required.Always)]
        public double CohortVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("db_version", Required = global::Newtonsoft.Json.Required.Always)]
        public double DbVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecated", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deprecated { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Passed { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wer", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Wer Wer { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("interruptions")]
        public global::G.InterruptionAnalysis? Interruptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_sentiments")]
        public global::G.SentimentAnalysis? UserSentiments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_sentiments")]
        public global::G.SentimentAnalysis? AgentSentiments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_naturalness_issues")]
        public global::G.AgentNaturalnessAnalysis? AgentNaturalnessIssues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mistranscribed_important_entities")]
        public global::G.MistranscribedImportantEntitiesAnalysis? MistranscribedImportantEntities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rag_analysis")]
        public global::G.RAGAnalysis? RagAnalysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_invocation_analysis")]
        public global::G.ToolCallInvocationAnalysis? ToolCallInvocationAnalysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_analysis")]
        public global::G.ToolCallAccuracyAnalysis? ToolCallAnalysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_transition_analysis")]
        public global::G.NodeTransitionAnalysis? NodeTransitionAnalysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_hallucination_analysis")]
        public global::G.HallucinationAnalysis? LlmHallucinationAnalysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_call_analysis")]
        public global::G.CallQATransferCallAnalysis? TransferCallAnalysis { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failure_reason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_metrics")]
        public global::System.Collections.Generic.IList<global::G.MetricResult>? FailedMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passed_metrics")]
        public global::System.Collections.Generic.IList<global::G.MetricResult>? PassedMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recommendations")]
        public global::System.Collections.Generic.IList<string>? Recommendations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("call_start_time_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public double CallStartTimeMs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public double CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public double UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("calibrated", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Calibrated { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallQA" /> class.
        /// </summary>
        /// <param name="callQaId"></param>
        /// <param name="callId"></param>
        /// <param name="cohortId"></param>
        /// <param name="cohortVersion"></param>
        /// <param name="dbVersion"></param>
        /// <param name="deprecated"></param>
        /// <param name="score"></param>
        /// <param name="passed"></param>
        /// <param name="wer"></param>
        /// <param name="callStartTimeMs"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="calibrated"></param>
        /// <param name="interruptions"></param>
        /// <param name="userSentiments"></param>
        /// <param name="agentSentiments"></param>
        /// <param name="agentNaturalnessIssues"></param>
        /// <param name="mistranscribedImportantEntities"></param>
        /// <param name="ragAnalysis"></param>
        /// <param name="toolCallInvocationAnalysis"></param>
        /// <param name="toolCallAnalysis"></param>
        /// <param name="nodeTransitionAnalysis"></param>
        /// <param name="llmHallucinationAnalysis"></param>
        /// <param name="transferCallAnalysis"></param>
        /// <param name="failureReason"></param>
        /// <param name="failedMetrics"></param>
        /// <param name="passedMetrics"></param>
        /// <param name="recommendations"></param>
        /// <param name="notes"></param>
        public CallQA(
            string callQaId,
            string callId,
            string cohortId,
            double cohortVersion,
            double dbVersion,
            bool deprecated,
            double score,
            bool passed,
            global::G.Wer wer,
            double callStartTimeMs,
            double createdAt,
            double updatedAt,
            bool calibrated,
            global::G.InterruptionAnalysis? interruptions,
            global::G.SentimentAnalysis? userSentiments,
            global::G.SentimentAnalysis? agentSentiments,
            global::G.AgentNaturalnessAnalysis? agentNaturalnessIssues,
            global::G.MistranscribedImportantEntitiesAnalysis? mistranscribedImportantEntities,
            global::G.RAGAnalysis? ragAnalysis,
            global::G.ToolCallInvocationAnalysis? toolCallInvocationAnalysis,
            global::G.ToolCallAccuracyAnalysis? toolCallAnalysis,
            global::G.NodeTransitionAnalysis? nodeTransitionAnalysis,
            global::G.HallucinationAnalysis? llmHallucinationAnalysis,
            global::G.CallQATransferCallAnalysis? transferCallAnalysis,
            string? failureReason,
            global::System.Collections.Generic.IList<global::G.MetricResult>? failedMetrics,
            global::System.Collections.Generic.IList<global::G.MetricResult>? passedMetrics,
            global::System.Collections.Generic.IList<string>? recommendations,
            string? notes)
        {
            this.CallQaId = callQaId ?? throw new global::System.ArgumentNullException(nameof(callQaId));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.CohortId = cohortId ?? throw new global::System.ArgumentNullException(nameof(cohortId));
            this.CohortVersion = cohortVersion;
            this.DbVersion = dbVersion;
            this.Deprecated = deprecated;
            this.Score = score;
            this.Passed = passed;
            this.Wer = wer ?? throw new global::System.ArgumentNullException(nameof(wer));
            this.Interruptions = interruptions;
            this.UserSentiments = userSentiments;
            this.AgentSentiments = agentSentiments;
            this.AgentNaturalnessIssues = agentNaturalnessIssues;
            this.MistranscribedImportantEntities = mistranscribedImportantEntities;
            this.RagAnalysis = ragAnalysis;
            this.ToolCallInvocationAnalysis = toolCallInvocationAnalysis;
            this.ToolCallAnalysis = toolCallAnalysis;
            this.NodeTransitionAnalysis = nodeTransitionAnalysis;
            this.LlmHallucinationAnalysis = llmHallucinationAnalysis;
            this.TransferCallAnalysis = transferCallAnalysis;
            this.FailureReason = failureReason;
            this.FailedMetrics = failedMetrics;
            this.PassedMetrics = passedMetrics;
            this.Recommendations = recommendations;
            this.Notes = notes;
            this.CallStartTimeMs = callStartTimeMs;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Calibrated = calibrated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallQA" /> class.
        /// </summary>
        public CallQA()
        {
        }
    }
}