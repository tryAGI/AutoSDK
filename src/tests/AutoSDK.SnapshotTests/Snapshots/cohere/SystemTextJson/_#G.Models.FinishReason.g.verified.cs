//HintName: G.Models.FinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        COMPLETE,
        /// <summary>
        /// 
        /// </summary>
        STOPSEQUENCE,
        /// <summary>
        /// 
        /// </summary>
        ERROR,
        /// <summary>
        /// 
        /// </summary>
        ERRORTOXIC,
        /// <summary>
        /// 
        /// </summary>
        ERRORLIMIT,
        /// <summary>
        /// 
        /// </summary>
        USERCANCEL,
        /// <summary>
        /// 
        /// </summary>
        MAXTOKENS,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinishReason value)
        {
            return value switch
            {
                FinishReason.COMPLETE => "COMPLETE",
                FinishReason.STOPSEQUENCE => "STOP_SEQUENCE",
                FinishReason.ERROR => "ERROR",
                FinishReason.ERRORTOXIC => "ERROR_TOXIC",
                FinishReason.ERRORLIMIT => "ERROR_LIMIT",
                FinishReason.USERCANCEL => "USER_CANCEL",
                FinishReason.MAXTOKENS => "MAX_TOKENS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinishReason? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETE" => FinishReason.COMPLETE,
                "STOP_SEQUENCE" => FinishReason.STOPSEQUENCE,
                "ERROR" => FinishReason.ERROR,
                "ERROR_TOXIC" => FinishReason.ERRORTOXIC,
                "ERROR_LIMIT" => FinishReason.ERRORLIMIT,
                "USER_CANCEL" => FinishReason.USERCANCEL,
                "MAX_TOKENS" => FinishReason.MAXTOKENS,
                _ => null,
            };
        }
    }
}