//HintName: G.Models.AgentScheduleExecutionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Outcome of this attempt.
    /// </summary>
    public enum AgentScheduleExecutionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentScheduleExecutionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentScheduleExecutionStatus value)
        {
            return value switch
            {
                AgentScheduleExecutionStatus.Success => "success",
                AgentScheduleExecutionStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentScheduleExecutionStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => AgentScheduleExecutionStatus.Success,
                "error" => AgentScheduleExecutionStatus.Error,
                _ => null,
            };
        }
    }
}