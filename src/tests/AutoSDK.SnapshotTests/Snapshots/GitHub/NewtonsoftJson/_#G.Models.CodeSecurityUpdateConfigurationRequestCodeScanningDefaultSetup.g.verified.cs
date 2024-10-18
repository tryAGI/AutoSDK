//HintName: G.Models.CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of code scanning default setup
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_set")]
        NotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup.Enabled,
                "disabled" => CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup.Disabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup.NotSet,
                _ => null,
            };
        }
    }
}