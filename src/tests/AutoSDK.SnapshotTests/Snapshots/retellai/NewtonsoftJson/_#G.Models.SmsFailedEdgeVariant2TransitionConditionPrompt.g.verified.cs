//HintName: G.Models.SmsFailedEdgeVariant2TransitionConditionPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be "failed to send" for SMS failed edge
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SmsFailedEdgeVariant2TransitionConditionPrompt
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Failed to send")]
        FailedToSend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsFailedEdgeVariant2TransitionConditionPromptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsFailedEdgeVariant2TransitionConditionPrompt value)
        {
            return value switch
            {
                SmsFailedEdgeVariant2TransitionConditionPrompt.FailedToSend => "Failed to send",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsFailedEdgeVariant2TransitionConditionPrompt? ToEnum(string value)
        {
            return value switch
            {
                "Failed to send" => SmsFailedEdgeVariant2TransitionConditionPrompt.FailedToSend,
                _ => null,
            };
        }
    }
}