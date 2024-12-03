//HintName: G.Models.RepositoryRuleCodeScanningType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryRuleCodeScanningType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeScanning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleCodeScanningTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleCodeScanningType value)
        {
            return value switch
            {
                RepositoryRuleCodeScanningType.CodeScanning => "code_scanning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleCodeScanningType? ToEnum(string value)
        {
            return value switch
            {
                "code_scanning" => RepositoryRuleCodeScanningType.CodeScanning,
                _ => null,
            };
        }
    }
}