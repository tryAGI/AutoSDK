//HintName: G.Models.CodeSecurityCreateConfigurationRequestSecretScanning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of secret scanning<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestSecretScanning
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
    public static class CodeSecurityCreateConfigurationRequestSecretScanningExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestSecretScanning value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestSecretScanning.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestSecretScanning.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestSecretScanning.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestSecretScanning? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationRequestSecretScanning.Enabled,
                "disabled" => CodeSecurityCreateConfigurationRequestSecretScanning.Disabled,
                "not_set" => CodeSecurityCreateConfigurationRequestSecretScanning.NotSet,
                _ => null,
            };
        }
    }
}