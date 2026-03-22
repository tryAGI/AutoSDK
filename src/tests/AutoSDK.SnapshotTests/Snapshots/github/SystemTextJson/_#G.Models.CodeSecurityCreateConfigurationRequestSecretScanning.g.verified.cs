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
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
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
                CodeSecurityCreateConfigurationRequestSecretScanning.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestSecretScanning.Enabled => "enabled",
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
                "disabled" => CodeSecurityCreateConfigurationRequestSecretScanning.Disabled,
                "enabled" => CodeSecurityCreateConfigurationRequestSecretScanning.Enabled,
                "not_set" => CodeSecurityCreateConfigurationRequestSecretScanning.NotSet,
                _ => null,
            };
        }
    }
}