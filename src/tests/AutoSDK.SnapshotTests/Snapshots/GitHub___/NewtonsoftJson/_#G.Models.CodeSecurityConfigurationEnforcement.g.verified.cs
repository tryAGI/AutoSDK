//HintName: G.Models.CodeSecurityConfigurationEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement status for a security configuration
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityConfigurationEnforcement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enforced")]
        Enforced,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unenforced")]
        Unenforced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityConfigurationEnforcementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationEnforcement value)
        {
            return value switch
            {
                CodeSecurityConfigurationEnforcement.Enforced => "enforced",
                CodeSecurityConfigurationEnforcement.Unenforced => "unenforced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationEnforcement? ToEnum(string value)
        {
            return value switch
            {
                "enforced" => CodeSecurityConfigurationEnforcement.Enforced,
                "unenforced" => CodeSecurityConfigurationEnforcement.Unenforced,
                _ => null,
            };
        }
    }
}