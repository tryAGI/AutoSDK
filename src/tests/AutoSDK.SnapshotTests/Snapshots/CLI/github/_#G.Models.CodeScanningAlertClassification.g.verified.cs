//HintName: G.Models.CodeScanningAlertClassification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A classification of the file. For example to identify it as generated.
    /// </summary>
    public enum CodeScanningAlertClassification
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
    public static class CodeScanningAlertClassificationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAlertClassification value)
        {
            return value switch
            {
                CodeScanningAlertClassification.Source => "source",
                CodeScanningAlertClassification.Generated => "generated",
                CodeScanningAlertClassification.Test => "test",
                CodeScanningAlertClassification.Library => "library",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAlertClassification? ToEnum(string value)
        {
            return value switch
            {
                "source" => CodeScanningAlertClassification.Source,
                "generated" => CodeScanningAlertClassification.Generated,
                "test" => CodeScanningAlertClassification.Test,
                "library" => CodeScanningAlertClassification.Library,
                _ => null,
            };
        }
    }
}