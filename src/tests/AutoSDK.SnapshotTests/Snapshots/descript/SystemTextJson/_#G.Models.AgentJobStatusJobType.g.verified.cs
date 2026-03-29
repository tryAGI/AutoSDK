//HintName: G.Models.AgentJobStatusJobType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of job<br/>
    /// Example: agent
    /// </summary>
    public enum AgentJobStatusJobType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentJobStatusJobTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentJobStatusJobType value)
        {
            return value switch
            {
                AgentJobStatusJobType.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentJobStatusJobType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => AgentJobStatusJobType.Agent,
                _ => null,
            };
        }
    }
}