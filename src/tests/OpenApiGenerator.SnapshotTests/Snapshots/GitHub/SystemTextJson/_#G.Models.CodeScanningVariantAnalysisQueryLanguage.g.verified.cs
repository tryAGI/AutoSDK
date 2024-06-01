//HintName: G.Models.CodeScanningVariantAnalysisQueryLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The language targeted by the CodeQL query
    /// </summary>
    public enum CodeScanningVariantAnalysisQueryLanguage
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
    public static class CodeScanningVariantAnalysisQueryLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningVariantAnalysisQueryLanguage value)
        {
            return value switch
            {
                CodeScanningVariantAnalysisQueryLanguage.Cpp => "cpp",
                CodeScanningVariantAnalysisQueryLanguage.Csharp => "csharp",
                CodeScanningVariantAnalysisQueryLanguage.Go => "go",
                CodeScanningVariantAnalysisQueryLanguage.Java => "java",
                CodeScanningVariantAnalysisQueryLanguage.Javascript => "javascript",
                CodeScanningVariantAnalysisQueryLanguage.Python => "python",
                CodeScanningVariantAnalysisQueryLanguage.Ruby => "ruby",
                CodeScanningVariantAnalysisQueryLanguage.Swift => "swift",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningVariantAnalysisQueryLanguage ToEnum(string value)
        {
            return value switch
            {
                "cpp" => CodeScanningVariantAnalysisQueryLanguage.Cpp,
                "csharp" => CodeScanningVariantAnalysisQueryLanguage.Csharp,
                "go" => CodeScanningVariantAnalysisQueryLanguage.Go,
                "java" => CodeScanningVariantAnalysisQueryLanguage.Java,
                "javascript" => CodeScanningVariantAnalysisQueryLanguage.Javascript,
                "python" => CodeScanningVariantAnalysisQueryLanguage.Python,
                "ruby" => CodeScanningVariantAnalysisQueryLanguage.Ruby,
                "swift" => CodeScanningVariantAnalysisQueryLanguage.Swift,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}