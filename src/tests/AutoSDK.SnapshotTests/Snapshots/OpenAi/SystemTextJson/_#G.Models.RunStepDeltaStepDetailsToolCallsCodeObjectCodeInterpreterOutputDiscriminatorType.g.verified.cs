//HintName: G.Models.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Logs,
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType value)
        {
            return value switch
            {
                RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.Logs => "logs",
                RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "logs" => RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.Logs,
                "image" => RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.Image,
                _ => null,
            };
        }
    }
}