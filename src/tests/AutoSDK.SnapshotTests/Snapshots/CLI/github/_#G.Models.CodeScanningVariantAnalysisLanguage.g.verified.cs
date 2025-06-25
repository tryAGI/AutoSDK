//HintName: G.Models.CodeScanningVariantAnalysisLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language targeted by the CodeQL query
    /// </summary>
    public enum CodeScanningVariantAnalysisLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Cpp,
        /// <summary>
        /// 
        /// </summary>
        Csharp,
        /// <summary>
        /// 
        /// </summary>
        Go,
        /// <summary>
        /// 
        /// </summary>
        Java,
        /// <summary>
        /// 
        /// </summary>
        Javascript,
        /// <summary>
        /// 
        /// </summary>
        Python,
        /// <summary>
        /// 
        /// </summary>
        Ruby,
        /// <summary>
        /// 
        /// </summary>
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