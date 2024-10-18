//HintName: G.Models.RunStepDeltaObjectDeltaStepDetailsDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStepDeltaObjectDeltaStepDetailsDiscriminatorType
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
    public static class RunStepDeltaObjectDeltaStepDetailsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDeltaObjectDeltaStepDetailsDiscriminatorType value)
        {
            return value switch
            {
                RunStepDeltaObjectDeltaStepDetailsDiscriminatorType.MessageCreation => "message_creation",
                RunStepDeltaObjectDeltaStepDetailsDiscriminatorType.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDeltaObjectDeltaStepDetailsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "message_creation" => RunStepDeltaObjectDeltaStepDetailsDiscriminatorType.MessageCreation,
                "tool_calls" => RunStepDeltaObjectDeltaStepDetailsDiscriminatorType.ToolCalls,
                _ => null,
            };
        }
    }
}