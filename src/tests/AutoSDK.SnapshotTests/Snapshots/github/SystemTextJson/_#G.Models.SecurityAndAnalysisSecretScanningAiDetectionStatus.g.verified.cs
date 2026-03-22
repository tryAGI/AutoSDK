//HintName: G.Models.SecurityAndAnalysisSecretScanningAiDetectionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecurityAndAnalysisSecretScanningAiDetectionStatus
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
    public static class SecurityAndAnalysisSecretScanningAiDetectionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAndAnalysisSecretScanningAiDetectionStatus value)
        {
            return value switch
            {
                SecurityAndAnalysisSecretScanningAiDetectionStatus.Disabled => "disabled",
                SecurityAndAnalysisSecretScanningAiDetectionStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAndAnalysisSecretScanningAiDetectionStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => SecurityAndAnalysisSecretScanningAiDetectionStatus.Disabled,
                "enabled" => SecurityAndAnalysisSecretScanningAiDetectionStatus.Enabled,
                _ => null,
            };
        }
    }
}