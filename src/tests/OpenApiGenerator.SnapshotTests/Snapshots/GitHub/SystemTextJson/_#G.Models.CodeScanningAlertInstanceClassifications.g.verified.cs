//HintName: G.Models.CodeScanningAlertInstanceClassifications.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A classification of the file. For example to identify it as generated.
    /// </summary>
    public enum CodeScanningAlertInstanceClassifications
    {
        /// <summary>
        /// 
        /// </summary>
        Source,
        /// <summary>
        /// 
        /// </summary>
        Generated,
        /// <summary>
        /// 
        /// </summary>
        Test,
        /// <summary>
        /// 
        /// </summary>
        Library,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningAlertInstanceClassificationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertInstanceClassifications value)
        {
            return value switch
            {
                CodeScanningAlertInstanceClassifications.Source => "source",
                CodeScanningAlertInstanceClassifications.Generated => "generated",
                CodeScanningAlertInstanceClassifications.Test => "test",
                CodeScanningAlertInstanceClassifications.Library => "library",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertInstanceClassifications ToEnum(string value)
        {
            return value switch
            {
                "source" => CodeScanningAlertInstanceClassifications.Source,
                "generated" => CodeScanningAlertInstanceClassifications.Generated,
                "test" => CodeScanningAlertInstanceClassifications.Test,
                "library" => CodeScanningAlertInstanceClassifications.Library,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}