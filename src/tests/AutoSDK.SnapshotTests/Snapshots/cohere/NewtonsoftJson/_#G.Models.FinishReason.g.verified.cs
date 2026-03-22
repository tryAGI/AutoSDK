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
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR_LIMIT")]
        ErrorLimit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR_TOXIC")]
        ErrorToxic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MAX_TOKENS")]
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STOP_SEQUENCE")]
        StopSequence,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="USER_CANCEL")]
        UserCancel,
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
                FinishReason.Error => "ERROR",
                FinishReason.ErrorLimit => "ERROR_LIMIT",
                FinishReason.ErrorToxic => "ERROR_TOXIC",
                FinishReason.MaxTokens => "MAX_TOKENS",
                FinishReason.StopSequence => "STOP_SEQUENCE",
                FinishReason.UserCancel => "USER_CANCEL",
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
                "ERROR" => FinishReason.Error,
                "ERROR_LIMIT" => FinishReason.ErrorLimit,
                "ERROR_TOXIC" => FinishReason.ErrorToxic,
                "MAX_TOKENS" => FinishReason.MaxTokens,
                "STOP_SEQUENCE" => FinishReason.StopSequence,
                "USER_CANCEL" => FinishReason.UserCancel,
                _ => null,
            };
        }
    }
}