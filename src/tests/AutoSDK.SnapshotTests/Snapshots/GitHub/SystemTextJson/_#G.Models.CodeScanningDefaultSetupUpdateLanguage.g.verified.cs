//HintName: G.Models.CodeScanningDefaultSetupUpdateLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeScanningDefaultSetupUpdateLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        CCpp,
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
        JavaKotlin,
        /// <summary>
        /// 
        /// </summary>
        JavascriptTypescript,
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
    public static class CodeScanningDefaultSetupUpdateLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupUpdateLanguage value)
        {
            return value switch
            {
                CodeScanningDefaultSetupUpdateLanguage.CCpp => "c-cpp",
                CodeScanningDefaultSetupUpdateLanguage.Csharp => "csharp",
                CodeScanningDefaultSetupUpdateLanguage.Go => "go",
                CodeScanningDefaultSetupUpdateLanguage.JavaKotlin => "java-kotlin",
                CodeScanningDefaultSetupUpdateLanguage.JavascriptTypescript => "javascript-typescript",
                CodeScanningDefaultSetupUpdateLanguage.Python => "python",
                CodeScanningDefaultSetupUpdateLanguage.Ruby => "ruby",
                CodeScanningDefaultSetupUpdateLanguage.Swift => "swift",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupUpdateLanguage? ToEnum(string value)
        {
            return value switch
            {
                "c-cpp" => CodeScanningDefaultSetupUpdateLanguage.CCpp,
                "csharp" => CodeScanningDefaultSetupUpdateLanguage.Csharp,
                "go" => CodeScanningDefaultSetupUpdateLanguage.Go,
                "java-kotlin" => CodeScanningDefaultSetupUpdateLanguage.JavaKotlin,
                "javascript-typescript" => CodeScanningDefaultSetupUpdateLanguage.JavascriptTypescript,
                "python" => CodeScanningDefaultSetupUpdateLanguage.Python,
                "ruby" => CodeScanningDefaultSetupUpdateLanguage.Ruby,
                "swift" => CodeScanningDefaultSetupUpdateLanguage.Swift,
                _ => null,
            };
        }
    }
}