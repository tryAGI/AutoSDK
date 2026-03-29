//HintName: G.Models.AnalyticsOperationColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the columns you want to perform the aggregation operation on.
    /// </summary>
    public enum AnalyticsOperationColumn
    {
        /// <summary>
        /// 
        /// </summary>
        Concurrency,
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        CostBreakdownAnalysisBreakdownSummary,
        /// <summary>
        /// 
        /// </summary>
        CostBreakdownLlm,
        /// <summary>
        /// 
        /// </summary>
        CostBreakdownLlmCachedPromptTokens,
        /// <summary>
        /// 
        /// </summary>
        CostBreakdownLlmCompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        CostBreakdownLlmPromptTokens,
        /// <summary>
        /// 
        /// </summary>
        CostBreakdownStt,
        /// <summary>
        /// 
        /// </summary>
        CostBreakdownTranscriber,
        /// <summary>
        /// 
        /// </summary>
        CostBreakdownTransport,
        /// <summary>
        /// 
        /// </summary>
        CostBreakdownTts,
        /// <summary>
        /// 
        /// </summary>
        CostBreakdownTtsCharacters,
        /// <summary>
        /// 
        /// </summary>
        CostBreakdownVapi,
        /// <summary>
        /// 
        /// </summary>
        Duration,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        MinutesUsed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsOperationColumnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsOperationColumn value)
        {
            return value switch
            {
                AnalyticsOperationColumn.Concurrency => "concurrency",
                AnalyticsOperationColumn.Cost => "cost",
                AnalyticsOperationColumn.CostBreakdownAnalysisBreakdownSummary => "costBreakdown.analysisBreakdown.summary",
                AnalyticsOperationColumn.CostBreakdownLlm => "costBreakdown.llm",
                AnalyticsOperationColumn.CostBreakdownLlmCachedPromptTokens => "costBreakdown.llmCachedPromptTokens",
                AnalyticsOperationColumn.CostBreakdownLlmCompletionTokens => "costBreakdown.llmCompletionTokens",
                AnalyticsOperationColumn.CostBreakdownLlmPromptTokens => "costBreakdown.llmPromptTokens",
                AnalyticsOperationColumn.CostBreakdownStt => "costBreakdown.stt",
                AnalyticsOperationColumn.CostBreakdownTranscriber => "costBreakdown.transcriber",
                AnalyticsOperationColumn.CostBreakdownTransport => "costBreakdown.transport",
                AnalyticsOperationColumn.CostBreakdownTts => "costBreakdown.tts",
                AnalyticsOperationColumn.CostBreakdownTtsCharacters => "costBreakdown.ttsCharacters",
                AnalyticsOperationColumn.CostBreakdownVapi => "costBreakdown.vapi",
                AnalyticsOperationColumn.Duration => "duration",
                AnalyticsOperationColumn.Id => "id",
                AnalyticsOperationColumn.MinutesUsed => "minutesUsed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsOperationColumn? ToEnum(string value)
        {
            return value switch
            {
                "concurrency" => AnalyticsOperationColumn.Concurrency,
                "cost" => AnalyticsOperationColumn.Cost,
                "costBreakdown.analysisBreakdown.summary" => AnalyticsOperationColumn.CostBreakdownAnalysisBreakdownSummary,
                "costBreakdown.llm" => AnalyticsOperationColumn.CostBreakdownLlm,
                "costBreakdown.llmCachedPromptTokens" => AnalyticsOperationColumn.CostBreakdownLlmCachedPromptTokens,
                "costBreakdown.llmCompletionTokens" => AnalyticsOperationColumn.CostBreakdownLlmCompletionTokens,
                "costBreakdown.llmPromptTokens" => AnalyticsOperationColumn.CostBreakdownLlmPromptTokens,
                "costBreakdown.stt" => AnalyticsOperationColumn.CostBreakdownStt,
                "costBreakdown.transcriber" => AnalyticsOperationColumn.CostBreakdownTranscriber,
                "costBreakdown.transport" => AnalyticsOperationColumn.CostBreakdownTransport,
                "costBreakdown.tts" => AnalyticsOperationColumn.CostBreakdownTts,
                "costBreakdown.ttsCharacters" => AnalyticsOperationColumn.CostBreakdownTtsCharacters,
                "costBreakdown.vapi" => AnalyticsOperationColumn.CostBreakdownVapi,
                "duration" => AnalyticsOperationColumn.Duration,
                "id" => AnalyticsOperationColumn.Id,
                "minutesUsed" => AnalyticsOperationColumn.MinutesUsed,
                _ => null,
            };
        }
    }
}