//HintName: G.Models.CodeScanningAlertClassification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A classification of the file. For example to identify it as generated.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningAlertClassification
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generated")]
        Generated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="library")]
        Library,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="source")]
        Source,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="test")]
        Test,
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
                CodeScanningAlertClassification.Generated => "generated",
                CodeScanningAlertClassification.Library => "library",
                CodeScanningAlertClassification.Source => "source",
                CodeScanningAlertClassification.Test => "test",
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
                "generated" => CodeScanningAlertClassification.Generated,
                "library" => CodeScanningAlertClassification.Library,
                "source" => CodeScanningAlertClassification.Source,
                "test" => CodeScanningAlertClassification.Test,
                _ => null,
            };
        }
    }
}