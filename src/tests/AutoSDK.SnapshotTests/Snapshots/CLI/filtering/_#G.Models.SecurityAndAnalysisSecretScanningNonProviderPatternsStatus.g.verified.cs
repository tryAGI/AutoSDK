//HintName: G.Models.SecurityAndAnalysisSecretScanningNonProviderPatternsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecurityAndAnalysisSecretScanningNonProviderPatternsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecurityAndAnalysisSecretScanningNonProviderPatternsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAndAnalysisSecretScanningNonProviderPatternsStatus value)
        {
            return value switch
            {
                SecurityAndAnalysisSecretScanningNonProviderPatternsStatus.Disabled => "disabled",
                SecurityAndAnalysisSecretScanningNonProviderPatternsStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAndAnalysisSecretScanningNonProviderPatternsStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => SecurityAndAnalysisSecretScanningNonProviderPatternsStatus.Disabled,
                "enabled" => SecurityAndAnalysisSecretScanningNonProviderPatternsStatus.Enabled,
                _ => null,
            };
        }
    }
}