//HintName: G.Models.RunStepDetailsToolCallsCodeOutputLogsObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `logs`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepDetailsToolCallsCodeOutputLogsObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logs")]
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