//HintName: G.Models.AlwaysEdgeVariant2TransitionConditionPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be "Always" for always edge
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlwaysEdgeVariant2TransitionConditionPrompt
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Always")]
        Always,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlwaysEdgeVariant2TransitionConditionPromptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlwaysEdgeVariant2TransitionConditionPrompt value)
        {
            return value switch
            {
                AlwaysEdgeVariant2TransitionConditionPrompt.Always => "Always",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlwaysEdgeVariant2TransitionConditionPrompt? ToEnum(string value)
        {
            return value switch
            {
                "Always" => AlwaysEdgeVariant2TransitionConditionPrompt.Always,
                _ => null,
            };
        }
    }
}