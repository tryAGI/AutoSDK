//HintName: G.Models.CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of code scanning default setup
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
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