//HintName: G.Models.ChCallQA.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChCallQA
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_qa_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallQaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohort_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CohortId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_start_time_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CallStartTimeMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DbVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deprecated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_count")]
        public double? WordCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_deletions")]
        public double? NumberDeletions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_insertions")]
        public double? NumberInsertions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_substitutions")]
        public double? NumberSubstitutions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption_count")]
        public double? InterruptionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_inference_count")]
        public double? LlmInferenceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_hallucination_count")]
        public double? LlmHallucinationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_positive_sentiment_count")]
        public double? UserPositiveSentimentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_neutral_sentiment_count")]
        public double? UserNeutralSentimentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_negative_sentiment_count")]
        public double? UserNegativeSentimentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_positive_sentiment_count")]
        public double? AgentPositiveSentimentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_neutral_sentiment_count")]
        public double? AgentNeutralSentimentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_negative_sentiment_count")]
        public double? AgentNegativeSentimentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_natural_utterance_count")]
        public double? AgentNaturalUtteranceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_success_count")]
        public double? RagSuccessCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag_total_count")]
        public double? RagTotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_call_success_count")]
        public double? TransferCallSuccessCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_call_total_count")]
        public double? TransferCallTotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_call_avg_latency")]
        public double? TransferCallAvgLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_average_latency")]
        public double? ToolCallAverageLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_success_count")]
        public double? ToolCallSuccessCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_total_count")]
        public double? ToolCallTotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_accurate_utterance_count")]
        public double? ToolCallAccurateUtteranceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_total_utterance_count")]
        public double? ToolCallTotalUtteranceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_success_count")]
        public double? TransitionSuccessCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_total_count")]
        public double? TransitionTotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_total_utterance_count")]
        public double? AgentTotalUtteranceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_total_utterance_count")]
        public double? UserTotalUtteranceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calibrated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Calibrated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChCallQA" /> class.
        /// </summary>
        /// <param name="callQaId"></param>
        /// <param name="callId"></param>
        /// <param name="cohortId"></param>
        /// <param name="callStartTimeMs"></param>
        /// <param name="dbVersion"></param>
        /// <param name="deprecated"></param>
        /// <param name="score"></param>
        /// <param name="passed"></param>
        /// <param name="calibrated"></param>
        /// <param name="wordCount"></param>
        /// <param name="numberDeletions"></param>
        /// <param name="numberInsertions"></param>
        /// <param name="numberSubstitutions"></param>
        /// <param name="interruptionCount"></param>
        /// <param name="llmInferenceCount"></param>
        /// <param name="llmHallucinationCount"></param>
        /// <param name="userPositiveSentimentCount"></param>
        /// <param name="userNeutralSentimentCount"></param>
        /// <param name="userNegativeSentimentCount"></param>
        /// <param name="agentPositiveSentimentCount"></param>
        /// <param name="agentNeutralSentimentCount"></param>
        /// <param name="agentNegativeSentimentCount"></param>
        /// <param name="agentNaturalUtteranceCount"></param>
        /// <param name="ragSuccessCount"></param>
        /// <param name="ragTotalCount"></param>
        /// <param name="transferCallSuccessCount"></param>
        /// <param name="transferCallTotalCount"></param>
        /// <param name="transferCallAvgLatency"></param>
        /// <param name="toolCallAverageLatency"></param>
        /// <param name="toolCallSuccessCount"></param>
        /// <param name="toolCallTotalCount"></param>
        /// <param name="toolCallAccurateUtteranceCount"></param>
        /// <param name="toolCallTotalUtteranceCount"></param>
        /// <param name="transitionSuccessCount"></param>
        /// <param name="transitionTotalCount"></param>
        /// <param name="agentTotalUtteranceCount"></param>
        /// <param name="userTotalUtteranceCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChCallQA(
            string callQaId,
            string callId,
            string cohortId,
            double callStartTimeMs,
            double dbVersion,
            bool deprecated,
            double score,
            bool passed,
            bool calibrated,
            double? wordCount,
            double? numberDeletions,
            double? numberInsertions,
            double? numberSubstitutions,
            double? interruptionCount,
            double? llmInferenceCount,
            double? llmHallucinationCount,
            double? userPositiveSentimentCount,
            double? userNeutralSentimentCount,
            double? userNegativeSentimentCount,
            double? agentPositiveSentimentCount,
            double? agentNeutralSentimentCount,
            double? agentNegativeSentimentCount,
            double? agentNaturalUtteranceCount,
            double? ragSuccessCount,
            double? ragTotalCount,
            double? transferCallSuccessCount,
            double? transferCallTotalCount,
            double? transferCallAvgLatency,
            double? toolCallAverageLatency,
            double? toolCallSuccessCount,
            double? toolCallTotalCount,
            double? toolCallAccurateUtteranceCount,
            double? toolCallTotalUtteranceCount,
            double? transitionSuccessCount,
            double? transitionTotalCount,
            double? agentTotalUtteranceCount,
            double? userTotalUtteranceCount)
        {
            this.CallQaId = callQaId ?? throw new global::System.ArgumentNullException(nameof(callQaId));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.CohortId = cohortId ?? throw new global::System.ArgumentNullException(nameof(cohortId));
            this.CallStartTimeMs = callStartTimeMs;
            this.DbVersion = dbVersion;
            this.Deprecated = deprecated;
            this.Score = score;
            this.Passed = passed;
            this.WordCount = wordCount;
            this.NumberDeletions = numberDeletions;
            this.NumberInsertions = numberInsertions;
            this.NumberSubstitutions = numberSubstitutions;
            this.InterruptionCount = interruptionCount;
            this.LlmInferenceCount = llmInferenceCount;
            this.LlmHallucinationCount = llmHallucinationCount;
            this.UserPositiveSentimentCount = userPositiveSentimentCount;
            this.UserNeutralSentimentCount = userNeutralSentimentCount;
            this.UserNegativeSentimentCount = userNegativeSentimentCount;
            this.AgentPositiveSentimentCount = agentPositiveSentimentCount;
            this.AgentNeutralSentimentCount = agentNeutralSentimentCount;
            this.AgentNegativeSentimentCount = agentNegativeSentimentCount;
            this.AgentNaturalUtteranceCount = agentNaturalUtteranceCount;
            this.RagSuccessCount = ragSuccessCount;
            this.RagTotalCount = ragTotalCount;
            this.TransferCallSuccessCount = transferCallSuccessCount;
            this.TransferCallTotalCount = transferCallTotalCount;
            this.TransferCallAvgLatency = transferCallAvgLatency;
            this.ToolCallAverageLatency = toolCallAverageLatency;
            this.ToolCallSuccessCount = toolCallSuccessCount;
            this.ToolCallTotalCount = toolCallTotalCount;
            this.ToolCallAccurateUtteranceCount = toolCallAccurateUtteranceCount;
            this.ToolCallTotalUtteranceCount = toolCallTotalUtteranceCount;
            this.TransitionSuccessCount = transitionSuccessCount;
            this.TransitionTotalCount = transitionTotalCount;
            this.AgentTotalUtteranceCount = agentTotalUtteranceCount;
            this.UserTotalUtteranceCount = userTotalUtteranceCount;
            this.Calibrated = calibrated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChCallQA" /> class.
        /// </summary>
        public ChCallQA()
        {
        }
    }
}