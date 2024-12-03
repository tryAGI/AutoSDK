//HintName: G.Models.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of code scanning default setup<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup
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
    public static class CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup.Enabled,
                "disabled" => CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup.Disabled,
                "not_set" => CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup.NotSet,
                _ => null,
            };
        }
    }
}