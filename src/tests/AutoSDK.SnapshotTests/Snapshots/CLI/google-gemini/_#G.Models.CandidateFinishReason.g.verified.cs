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
        FINISHREASONUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        STOP,
        /// <summary>
        /// 
        /// </summary>
        MAXTOKENS,
        /// <summary>
        /// 
        /// </summary>
        SAFETY,
        /// <summary>
        /// 
        /// </summary>
        RECITATION,
        /// <summary>
        /// 
        /// </summary>
        OTHER,
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
                CandidateFinishReason.FINISHREASONUNSPECIFIED => "FINISH_REASON_UNSPECIFIED",
                CandidateFinishReason.STOP => "STOP",
                CandidateFinishReason.MAXTOKENS => "MAX_TOKENS",
                CandidateFinishReason.SAFETY => "SAFETY",
                CandidateFinishReason.RECITATION => "RECITATION",
                CandidateFinishReason.OTHER => "OTHER",
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
                "FINISH_REASON_UNSPECIFIED" => CandidateFinishReason.FINISHREASONUNSPECIFIED,
                "STOP" => CandidateFinishReason.STOP,
                "MAX_TOKENS" => CandidateFinishReason.MAXTOKENS,
                "SAFETY" => CandidateFinishReason.SAFETY,
                "RECITATION" => CandidateFinishReason.RECITATION,
                "OTHER" => CandidateFinishReason.OTHER,
                _ => null,
            };
        }
    }
}