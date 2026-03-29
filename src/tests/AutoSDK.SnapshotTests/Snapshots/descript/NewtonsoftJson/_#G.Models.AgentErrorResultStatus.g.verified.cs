//HintName: G.Models.AgentErrorResultStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates the job failed<br/>
    /// Example: error
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentErrorResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentErrorResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentErrorResultStatus value)
        {
            return value switch
            {
                AgentErrorResultStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentErrorResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => AgentErrorResultStatus.Error,
                _ => null,
            };
        }
    }
}