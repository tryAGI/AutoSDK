//HintName: G.Models.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType
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
    public static class RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType value)
        {
            return value switch
            {
                RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.Logs => "logs",
                RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "logs" => RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.Logs,
                "image" => RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.Image,
                _ => null,
            };
        }
    }
}