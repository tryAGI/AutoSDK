//HintName: G.Models.CodeScanningVariantAnalysisLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language targeted by the CodeQL query
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningVariantAnalysisLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cpp")]
        Cpp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="csharp")]
        Csharp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="go")]
        Go,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="java")]
        Java,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="javascript")]
        Javascript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="python")]
        Python,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ruby")]
        Ruby,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="swift")]
        Swift,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningVariantAnalysisLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningVariantAnalysisLanguage value)
        {
            return value switch
            {
                CodeScanningVariantAnalysisLanguage.Cpp => "cpp",
                CodeScanningVariantAnalysisLanguage.Csharp => "csharp",
                CodeScanningVariantAnalysisLanguage.Go => "go",
                CodeScanningVariantAnalysisLanguage.Java => "java",
                CodeScanningVariantAnalysisLanguage.Javascript => "javascript",
                CodeScanningVariantAnalysisLanguage.Python => "python",
                CodeScanningVariantAnalysisLanguage.Ruby => "ruby",
                CodeScanningVariantAnalysisLanguage.Swift => "swift",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningVariantAnalysisLanguage? ToEnum(string value)
        {
            return value switch
            {
                "cpp" => CodeScanningVariantAnalysisLanguage.Cpp,
                "csharp" => CodeScanningVariantAnalysisLanguage.Csharp,
                "go" => CodeScanningVariantAnalysisLanguage.Go,
                "java" => CodeScanningVariantAnalysisLanguage.Java,
                "javascript" => CodeScanningVariantAnalysisLanguage.Javascript,
                "python" => CodeScanningVariantAnalysisLanguage.Python,
                "ruby" => CodeScanningVariantAnalysisLanguage.Ruby,
                "swift" => CodeScanningVariantAnalysisLanguage.Swift,
                _ => null,
            };
        }
    }
}