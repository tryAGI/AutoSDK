//HintName: G.Models.CodeSecurityCreateConfigurationRequestEnforcement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement status for a security configuration<br/>
    /// Default Value: enforced
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityCreateConfigurationRequestEnforcement
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
    public static class CodeSecurityCreateConfigurationRequestEnforcementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestEnforcement value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestEnforcement.Enforced => "enforced",
                CodeSecurityCreateConfigurationRequestEnforcement.Unenforced => "unenforced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestEnforcement? ToEnum(string value)
        {
            return value switch
            {
                "enforced" => CodeSecurityCreateConfigurationRequestEnforcement.Enforced,
                "unenforced" => CodeSecurityCreateConfigurationRequestEnforcement.Unenforced,
                _ => null,
            };
        }
    }
}