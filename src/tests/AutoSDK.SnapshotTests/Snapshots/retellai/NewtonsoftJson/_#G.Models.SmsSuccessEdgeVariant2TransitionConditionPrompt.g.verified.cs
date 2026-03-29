//HintName: G.Models.SmsSuccessEdgeVariant2TransitionConditionPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be "sent successfully" for SMS success edge
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SmsSuccessEdgeVariant2TransitionConditionPrompt
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Sent successfully")]
        SentSuccessfully,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsSuccessEdgeVariant2TransitionConditionPromptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsSuccessEdgeVariant2TransitionConditionPrompt value)
        {
            return value switch
            {
                SmsSuccessEdgeVariant2TransitionConditionPrompt.SentSuccessfully => "Sent successfully",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsSuccessEdgeVariant2TransitionConditionPrompt? ToEnum(string value)
        {
            return value switch
            {
                "Sent successfully" => SmsSuccessEdgeVariant2TransitionConditionPrompt.SentSuccessfully,
                _ => null,
            };
        }
    }
}