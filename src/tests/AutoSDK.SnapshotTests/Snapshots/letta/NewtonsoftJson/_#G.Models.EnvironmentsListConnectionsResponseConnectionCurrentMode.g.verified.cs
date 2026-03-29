//HintName: G.Models.EnvironmentsListConnectionsResponseConnectionCurrentMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EnvironmentsListConnectionsResponseConnectionCurrentMode
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
    public static class EnvironmentsListConnectionsResponseConnectionCurrentModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentsListConnectionsResponseConnectionCurrentMode value)
        {
            return value switch
            {
                EnvironmentsListConnectionsResponseConnectionCurrentMode.AcceptEdits => "acceptEdits",
                EnvironmentsListConnectionsResponseConnectionCurrentMode.BypassPermissions => "bypassPermissions",
                EnvironmentsListConnectionsResponseConnectionCurrentMode.Default => "default",
                EnvironmentsListConnectionsResponseConnectionCurrentMode.Plan => "plan",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentsListConnectionsResponseConnectionCurrentMode? ToEnum(string value)
        {
            return value switch
            {
                "acceptEdits" => EnvironmentsListConnectionsResponseConnectionCurrentMode.AcceptEdits,
                "bypassPermissions" => EnvironmentsListConnectionsResponseConnectionCurrentMode.BypassPermissions,
                "default" => EnvironmentsListConnectionsResponseConnectionCurrentMode.Default,
                "plan" => EnvironmentsListConnectionsResponseConnectionCurrentMode.Plan,
                _ => null,
            };
        }
    }
}