//HintName: G.Models.GetAgentResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current status of the cloud agent<br/>
    /// Example: RUNNING
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAgentResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CREATING")]
        Creating,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EXPIRED")]
        Expired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FINISHED")]
        Finished,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentResponseStatus value)
        {
            return value switch
            {
                GetAgentResponseStatus.Creating => "CREATING",
                GetAgentResponseStatus.Error => "ERROR",
                GetAgentResponseStatus.Expired => "EXPIRED",
                GetAgentResponseStatus.Finished => "FINISHED",
                GetAgentResponseStatus.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATING" => GetAgentResponseStatus.Creating,
                "ERROR" => GetAgentResponseStatus.Error,
                "EXPIRED" => GetAgentResponseStatus.Expired,
                "FINISHED" => GetAgentResponseStatus.Finished,
                "RUNNING" => GetAgentResponseStatus.Running,
                _ => null,
            };
        }
    }
}