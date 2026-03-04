//HintName: G.Models.FinishReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETE")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STOP_SEQUENCE")]
        StopSequence,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR_TOXIC")]
        ErrorToxic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR_LIMIT")]
        ErrorLimit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="USER_CANCEL")]
        UserCancel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MAX_TOKENS")]
        MaxTokens,
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
                FinishReason.Complete => "COMPLETE",
                FinishReason.StopSequence => "STOP_SEQUENCE",
                FinishReason.Error => "ERROR",
                FinishReason.ErrorToxic => "ERROR_TOXIC",
                FinishReason.ErrorLimit => "ERROR_LIMIT",
                FinishReason.UserCancel => "USER_CANCEL",
                FinishReason.MaxTokens => "MAX_TOKENS",
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
                "COMPLETE" => FinishReason.Complete,
                "STOP_SEQUENCE" => FinishReason.StopSequence,
                "ERROR" => FinishReason.Error,
                "ERROR_TOXIC" => FinishReason.ErrorToxic,
                "ERROR_LIMIT" => FinishReason.ErrorLimit,
                "USER_CANCEL" => FinishReason.UserCancel,
                "MAX_TOKENS" => FinishReason.MaxTokens,
                _ => null,
            };
        }
    }
}