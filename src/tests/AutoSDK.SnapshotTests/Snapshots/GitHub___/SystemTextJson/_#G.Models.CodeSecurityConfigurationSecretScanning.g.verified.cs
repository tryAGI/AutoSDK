//HintName: G.Models.CodeSecurityConfigurationSecretScanning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of secret scanning
    /// </summary>
    public enum CodeSecurityConfigurationSecretScanning
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
    public static class CodeSecurityConfigurationSecretScanningExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationSecretScanning value)
        {
            return value switch
            {
                CodeSecurityConfigurationSecretScanning.Enabled => "enabled",
                CodeSecurityConfigurationSecretScanning.Disabled => "disabled",
                CodeSecurityConfigurationSecretScanning.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationSecretScanning? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityConfigurationSecretScanning.Enabled,
                "disabled" => CodeSecurityConfigurationSecretScanning.Disabled,
                "not_set" => CodeSecurityConfigurationSecretScanning.NotSet,
                _ => null,
            };
        }
    }
}