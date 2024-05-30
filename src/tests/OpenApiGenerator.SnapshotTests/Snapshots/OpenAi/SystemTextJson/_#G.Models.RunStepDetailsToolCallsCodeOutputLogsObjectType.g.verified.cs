//HintName: G.Models.RunStepDetailsToolCallsCodeOutputLogsObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `logs`.
    /// </summary>
    public enum RunStepDetailsToolCallsCodeOutputLogsObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Logs,
    }

    public static class RunStepDetailsToolCallsCodeOutputLogsObjectTypeExtensions
    {
        public static string ToValueString(this RunStepDetailsToolCallsCodeOutputLogsObjectType value)
        {
            return value switch
            {
                RunStepDetailsToolCallsCodeOutputLogsObjectType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDetailsToolCallsCodeOutputLogsObjectType ToEnum(string value)
        {
            return value switch
            {
                "logs" => RunStepDetailsToolCallsCodeOutputLogsObjectType.Logs,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDetailsToolCallsCodeOutputLogsObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDetailsToolCallsCodeOutputLogsObjectType.Logs,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}