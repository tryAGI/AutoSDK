//HintName: G.Models.SmsSuccessEdgeVariant2TransitionConditionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SmsSuccessEdgeVariant2TransitionConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsSuccessEdgeVariant2TransitionConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsSuccessEdgeVariant2TransitionConditionType value)
        {
            return value switch
            {
                SmsSuccessEdgeVariant2TransitionConditionType.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsSuccessEdgeVariant2TransitionConditionType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => SmsSuccessEdgeVariant2TransitionConditionType.Prompt,
                _ => null,
            };
        }
    }
}