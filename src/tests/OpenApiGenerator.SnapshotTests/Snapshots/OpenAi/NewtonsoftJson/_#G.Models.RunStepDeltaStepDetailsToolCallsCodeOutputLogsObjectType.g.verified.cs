//HintName: G.Models.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `logs`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logs")]
        Logs,
    }

    public static class RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectTypeExtensions
    {
        public static string ToValueString(this RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType value)
        {
            return value switch
            {
                RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType.Logs => "logs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType ToEnum(string value)
        {
            return value switch
            {
                "logs" => RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType.Logs,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunStepDeltaStepDetailsToolCallsCodeOutputLogsObjectType.Logs,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}