//HintName: G.Models.CandidateFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional. Output only. The reason why the model stopped generating tokens. If empty, the model has not stopped generating the tokens.<br/>
    /// Included only in responses
    /// </summary>
    public enum CandidateFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        FinishReasonUnspecified,
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        Safety,
        /// <summary>
        /// 
        /// </summary>
        Recitation,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CandidateFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CandidateFinishReason value)
        {
            return value switch
            {
                CandidateFinishReason.FinishReasonUnspecified => "FINISH_REASON_UNSPECIFIED",
                CandidateFinishReason.Stop => "STOP",
                CandidateFinishReason.MaxTokens => "MAX_TOKENS",
                CandidateFinishReason.Safety => "SAFETY",
                CandidateFinishReason.Recitation => "RECITATION",
                CandidateFinishReason.Other => "OTHER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CandidateFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "FINISH_REASON_UNSPECIFIED" => CandidateFinishReason.FinishReasonUnspecified,
                "STOP" => CandidateFinishReason.Stop,
                "MAX_TOKENS" => CandidateFinishReason.MaxTokens,
                "SAFETY" => CandidateFinishReason.Safety,
                "RECITATION" => CandidateFinishReason.Recitation,
                "OTHER" => CandidateFinishReason.Other,
                _ => null,
            };
        }
    }
}