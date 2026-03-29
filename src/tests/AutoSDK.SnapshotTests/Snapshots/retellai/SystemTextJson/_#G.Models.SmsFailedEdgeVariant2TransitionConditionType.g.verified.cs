//HintName: G.Models.SmsFailedEdgeVariant2TransitionConditionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SmsFailedEdgeVariant2TransitionConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsFailedEdgeVariant2TransitionConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsFailedEdgeVariant2TransitionConditionType value)
        {
            return value switch
            {
                SmsFailedEdgeVariant2TransitionConditionType.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsFailedEdgeVariant2TransitionConditionType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => SmsFailedEdgeVariant2TransitionConditionType.Prompt,
                _ => null,
            };
        }
    }
}