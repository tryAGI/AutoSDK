//HintName: G.Models.AgentV1ServerEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentV1ServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AgentStarted")]
        AgentStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AgentThinking")]
        AgentThinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentV1ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentV1ServerEventDiscriminatorType value)
        {
            return value switch
            {
                AgentV1ServerEventDiscriminatorType.AgentStarted => "AgentStarted",
                AgentV1ServerEventDiscriminatorType.AgentThinking => "AgentThinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentV1ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "AgentStarted" => AgentV1ServerEventDiscriminatorType.AgentStarted,
                "AgentThinking" => AgentV1ServerEventDiscriminatorType.AgentThinking,
                _ => null,
            };
        }
    }
}