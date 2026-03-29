//HintName: G.Models.EnvironmentsGetConnectionResponseCurrentMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EnvironmentsGetConnectionResponseCurrentMode
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
    public static class EnvironmentsGetConnectionResponseCurrentModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentsGetConnectionResponseCurrentMode value)
        {
            return value switch
            {
                EnvironmentsGetConnectionResponseCurrentMode.AcceptEdits => "acceptEdits",
                EnvironmentsGetConnectionResponseCurrentMode.BypassPermissions => "bypassPermissions",
                EnvironmentsGetConnectionResponseCurrentMode.Default => "default",
                EnvironmentsGetConnectionResponseCurrentMode.Plan => "plan",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentsGetConnectionResponseCurrentMode? ToEnum(string value)
        {
            return value switch
            {
                "acceptEdits" => EnvironmentsGetConnectionResponseCurrentMode.AcceptEdits,
                "bypassPermissions" => EnvironmentsGetConnectionResponseCurrentMode.BypassPermissions,
                "default" => EnvironmentsGetConnectionResponseCurrentMode.Default,
                "plan" => EnvironmentsGetConnectionResponseCurrentMode.Plan,
                _ => null,
            };
        }
    }
}