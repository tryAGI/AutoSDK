//HintName: G.Models.AlwaysEdgeVariant2TransitionConditionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlwaysEdgeVariant2TransitionConditionType
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
    public static class AlwaysEdgeVariant2TransitionConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlwaysEdgeVariant2TransitionConditionType value)
        {
            return value switch
            {
                AlwaysEdgeVariant2TransitionConditionType.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlwaysEdgeVariant2TransitionConditionType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => AlwaysEdgeVariant2TransitionConditionType.Prompt,
                _ => null,
            };
        }
    }
}