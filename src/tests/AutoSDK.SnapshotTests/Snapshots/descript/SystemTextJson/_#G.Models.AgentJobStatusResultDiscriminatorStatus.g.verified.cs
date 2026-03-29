//HintName: G.Models.AgentJobStatusResultDiscriminatorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentJobStatusResultDiscriminatorStatus
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
    public static class AgentJobStatusResultDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentJobStatusResultDiscriminatorStatus value)
        {
            return value switch
            {
                AgentJobStatusResultDiscriminatorStatus.Error => "error",
                AgentJobStatusResultDiscriminatorStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentJobStatusResultDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => AgentJobStatusResultDiscriminatorStatus.Error,
                "success" => AgentJobStatusResultDiscriminatorStatus.Success,
                _ => null,
            };
        }
    }
}