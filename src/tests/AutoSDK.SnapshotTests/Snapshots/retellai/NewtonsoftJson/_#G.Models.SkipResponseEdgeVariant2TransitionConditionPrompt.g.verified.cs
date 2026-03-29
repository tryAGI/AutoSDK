//HintName: G.Models.SkipResponseEdgeVariant2TransitionConditionPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be "Skip response" for skip response edge
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SkipResponseEdgeVariant2TransitionConditionPrompt
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Skip response")]
        SkipResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkipResponseEdgeVariant2TransitionConditionPromptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkipResponseEdgeVariant2TransitionConditionPrompt value)
        {
            return value switch
            {
                SkipResponseEdgeVariant2TransitionConditionPrompt.SkipResponse => "Skip response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkipResponseEdgeVariant2TransitionConditionPrompt? ToEnum(string value)
        {
            return value switch
            {
                "Skip response" => SkipResponseEdgeVariant2TransitionConditionPrompt.SkipResponse,
                _ => null,
            };
        }
    }
}