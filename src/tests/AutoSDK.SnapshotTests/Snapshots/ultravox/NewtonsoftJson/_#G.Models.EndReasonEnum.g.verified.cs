//HintName: G.Models.EndReasonEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `unjoined` - Client never joined<br/>
    /// * `hangup` - Client hung up<br/>
    /// * `agent_hangup` - Agent hung up<br/>
    /// * `timeout` - Call timed out<br/>
    /// * `connection_error` - Connection error<br/>
    /// * `system_error` - System error
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EndReasonEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_hangup")]
        AgentHangup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="connection_error")]
        ConnectionError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hangup")]
        Hangup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system_error")]
        SystemError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timeout")]
        Timeout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unjoined")]
        Unjoined,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndReasonEnum value)
        {
            return value switch
            {
                EndReasonEnum.AgentHangup => "agent_hangup",
                EndReasonEnum.ConnectionError => "connection_error",
                EndReasonEnum.Hangup => "hangup",
                EndReasonEnum.SystemError => "system_error",
                EndReasonEnum.Timeout => "timeout",
                EndReasonEnum.Unjoined => "unjoined",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "agent_hangup" => EndReasonEnum.AgentHangup,
                "connection_error" => EndReasonEnum.ConnectionError,
                "hangup" => EndReasonEnum.Hangup,
                "system_error" => EndReasonEnum.SystemError,
                "timeout" => EndReasonEnum.Timeout,
                "unjoined" => EndReasonEnum.Unjoined,
                _ => null,
            };
        }
    }
}