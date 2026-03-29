//HintName: G.Models.EnvironmentsSendModeChangeRequestMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EnvironmentsSendModeChangeRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="acceptEdits")]
        AcceptEdits,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bypassPermissions")]
        BypassPermissions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plan")]
        Plan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentsSendModeChangeRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentsSendModeChangeRequestMode value)
        {
            return value switch
            {
                EnvironmentsSendModeChangeRequestMode.AcceptEdits => "acceptEdits",
                EnvironmentsSendModeChangeRequestMode.BypassPermissions => "bypassPermissions",
                EnvironmentsSendModeChangeRequestMode.Default => "default",
                EnvironmentsSendModeChangeRequestMode.Plan => "plan",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentsSendModeChangeRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "acceptEdits" => EnvironmentsSendModeChangeRequestMode.AcceptEdits,
                "bypassPermissions" => EnvironmentsSendModeChangeRequestMode.BypassPermissions,
                "default" => EnvironmentsSendModeChangeRequestMode.Default,
                "plan" => EnvironmentsSendModeChangeRequestMode.Plan,
                _ => null,
            };
        }
    }
}