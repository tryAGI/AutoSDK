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
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Interpreting,
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
                CodeInterpreterToolCallStatus.Completed => "completed",
                CodeInterpreterToolCallStatus.InProgress => "in_progress",
                CodeInterpreterToolCallStatus.Interpreting => "interpreting",
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
                "completed" => CodeInterpreterToolCallStatus.Completed,
                "in_progress" => CodeInterpreterToolCallStatus.InProgress,
                "interpreting" => CodeInterpreterToolCallStatus.Interpreting,
                _ => null,
            };
        }
    }
}