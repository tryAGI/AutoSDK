//HintName: G.Models.CodeInterpreterToolCallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the code interpreter tool call.
    /// </summary>
    public enum CodeInterpreterToolCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Interpreting,
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterToolCallStatus value)
        {
            return value switch
            {
                CodeInterpreterToolCallStatus.InProgress => "in_progress",
                CodeInterpreterToolCallStatus.Interpreting => "interpreting",
                CodeInterpreterToolCallStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => CodeInterpreterToolCallStatus.InProgress,
                "interpreting" => CodeInterpreterToolCallStatus.Interpreting,
                "completed" => CodeInterpreterToolCallStatus.Completed,
                _ => null,
            };
        }
    }
}