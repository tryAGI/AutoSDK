//HintName: G.Models.RunStepObjectStepDetailsDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStepObjectStepDetailsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        MessageCreation,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepObjectStepDetailsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepObjectStepDetailsDiscriminatorType value)
        {
            return value switch
            {
                RunStepObjectStepDetailsDiscriminatorType.MessageCreation => "message_creation",
                RunStepObjectStepDetailsDiscriminatorType.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepObjectStepDetailsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "message_creation" => RunStepObjectStepDetailsDiscriminatorType.MessageCreation,
                "tool_calls" => RunStepObjectStepDetailsDiscriminatorType.ToolCalls,
                _ => null,
            };
        }
    }
}