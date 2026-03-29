//HintName: G.Models.AnalyticsOperationColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the columns you want to perform the aggregation operation on.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnalyticsOperationColumn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="concurrency")]
        Concurrency,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cost")]
        Cost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="costBreakdown.analysisBreakdown.summary")]
        CostBreakdownAnalysisBreakdownSummary,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="costBreakdown.llm")]
        CostBreakdownLlm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="costBreakdown.llmCachedPromptTokens")]
        CostBreakdownLlmCachedPromptTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="costBreakdown.llmCompletionTokens")]
        CostBreakdownLlmCompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="costBreakdown.llmPromptTokens")]
        CostBreakdownLlmPromptTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="costBreakdown.stt")]
        CostBreakdownStt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="costBreakdown.transcriber")]
        CostBreakdownTranscriber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="costBreakdown.transport")]
        CostBreakdownTransport,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="costBreakdown.tts")]
        CostBreakdownTts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="costBreakdown.ttsCharacters")]
        CostBreakdownTtsCharacters,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="costBreakdown.vapi")]
        CostBreakdownVapi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="duration")]
        Duration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="id")]
        Id,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minutesUsed")]
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