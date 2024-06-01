//HintName: G.Models.CodeScanningDefaultSetupUpdateLanguages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeScanningDefaultSetupUpdateLanguages
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
    public static class CodeScanningDefaultSetupUpdateLanguagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupUpdateLanguages value)
        {
            return value switch
            {
                CodeScanningDefaultSetupUpdateLanguages.CCpp => "c-cpp",
                CodeScanningDefaultSetupUpdateLanguages.Csharp => "csharp",
                CodeScanningDefaultSetupUpdateLanguages.Go => "go",
                CodeScanningDefaultSetupUpdateLanguages.JavaKotlin => "java-kotlin",
                CodeScanningDefaultSetupUpdateLanguages.JavascriptTypescript => "javascript-typescript",
                CodeScanningDefaultSetupUpdateLanguages.Python => "python",
                CodeScanningDefaultSetupUpdateLanguages.Ruby => "ruby",
                CodeScanningDefaultSetupUpdateLanguages.Swift => "swift",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupUpdateLanguages ToEnum(string value)
        {
            return value switch
            {
                "c-cpp" => CodeScanningDefaultSetupUpdateLanguages.CCpp,
                "csharp" => CodeScanningDefaultSetupUpdateLanguages.Csharp,
                "go" => CodeScanningDefaultSetupUpdateLanguages.Go,
                "java-kotlin" => CodeScanningDefaultSetupUpdateLanguages.JavaKotlin,
                "javascript-typescript" => CodeScanningDefaultSetupUpdateLanguages.JavascriptTypescript,
                "python" => CodeScanningDefaultSetupUpdateLanguages.Python,
                "ruby" => CodeScanningDefaultSetupUpdateLanguages.Ruby,
                "swift" => CodeScanningDefaultSetupUpdateLanguages.Swift,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}