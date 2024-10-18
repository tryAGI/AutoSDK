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
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
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
                SecurityAndAnalysisSecretScanningNonProviderPatternsStatus.Enabled => "enabled",
                SecurityAndAnalysisSecretScanningNonProviderPatternsStatus.Disabled => "disabled",
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
                "enabled" => SecurityAndAnalysisSecretScanningNonProviderPatternsStatus.Enabled,
                "disabled" => SecurityAndAnalysisSecretScanningNonProviderPatternsStatus.Disabled,
                _ => null,
            };
        }
    }
}