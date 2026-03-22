//HintName: G.Models.CandidateFinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional. Output only. The reason why the model stopped generating tokens. If empty, the model has not stopped generating the tokens.<br/>
    /// Included only in responses
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CandidateFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FINISH_REASON_UNSPECIFIED")]
        FinishReasonUnspecified,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MAX_TOKENS")]
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OTHER")]
        Other,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RECITATION")]
        Recitation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SAFETY")]
        Safety,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STOP")]
        Stop,
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
                CandidateFinishReason.MaxTokens => "MAX_TOKENS",
                CandidateFinishReason.Other => "OTHER",
                CandidateFinishReason.Recitation => "RECITATION",
                CandidateFinishReason.Safety => "SAFETY",
                CandidateFinishReason.Stop => "STOP",
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
                "MAX_TOKENS" => CandidateFinishReason.MaxTokens,
                "OTHER" => CandidateFinishReason.Other,
                "RECITATION" => CandidateFinishReason.Recitation,
                "SAFETY" => CandidateFinishReason.Safety,
                "STOP" => CandidateFinishReason.Stop,
                _ => null,
            };
        }
    }
}