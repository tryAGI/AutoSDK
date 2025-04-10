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
    public enum EndReasonEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Unjoined,
        /// <summary>
        /// 
        /// </summary>
        Hangup,
        /// <summary>
        /// 
        /// </summary>
        AgentHangup,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
        /// <summary>
        /// 
        /// </summary>
        ConnectionError,
        /// <summary>
        /// 
        /// </summary>
        SystemError,
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
                EndReasonEnum.Unjoined => "unjoined",
                EndReasonEnum.Hangup => "hangup",
                EndReasonEnum.AgentHangup => "agent_hangup",
                EndReasonEnum.Timeout => "timeout",
                EndReasonEnum.ConnectionError => "connection_error",
                EndReasonEnum.SystemError => "system_error",
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
                "unjoined" => EndReasonEnum.Unjoined,
                "hangup" => EndReasonEnum.Hangup,
                "agent_hangup" => EndReasonEnum.AgentHangup,
                "timeout" => EndReasonEnum.Timeout,
                "connection_error" => EndReasonEnum.ConnectionError,
                "system_error" => EndReasonEnum.SystemError,
                _ => null,
            };
        }
    }
}