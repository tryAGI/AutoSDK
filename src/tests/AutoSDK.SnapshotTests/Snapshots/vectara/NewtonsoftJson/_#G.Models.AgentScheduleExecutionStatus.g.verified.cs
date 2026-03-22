//HintName: G.Models.AgentScheduleExecutionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Outcome of this attempt.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentScheduleExecutionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
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
                AgentScheduleExecutionStatus.Error => "error",
                AgentScheduleExecutionStatus.Success => "success",
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
                "error" => AgentScheduleExecutionStatus.Error,
                "success" => AgentScheduleExecutionStatus.Success,
                _ => null,
            };
        }
    }
}