//HintName: G.Models.ToolExecutionResultStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the tool execution and return object
    /// </summary>
    public enum ToolExecutionResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolExecutionResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolExecutionResultStatus value)
        {
            return value switch
            {
                ToolExecutionResultStatus.Error => "error",
                ToolExecutionResultStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolExecutionResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ToolExecutionResultStatus.Error,
                "success" => ToolExecutionResultStatus.Success,
                _ => null,
            };
        }
    }
}