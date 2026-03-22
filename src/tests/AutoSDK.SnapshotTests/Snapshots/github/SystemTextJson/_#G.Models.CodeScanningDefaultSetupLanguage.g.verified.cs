//HintName: G.Models.CodeScanningDefaultSetupLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeScanningDefaultSetupLanguage
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
        Javascript,
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
        /// <summary>
        /// 
        /// </summary>
        Typescript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningDefaultSetupLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupLanguage value)
        {
            return value switch
            {
                CodeScanningDefaultSetupLanguage.CCpp => "c-cpp",
                CodeScanningDefaultSetupLanguage.Csharp => "csharp",
                CodeScanningDefaultSetupLanguage.Go => "go",
                CodeScanningDefaultSetupLanguage.JavaKotlin => "java-kotlin",
                CodeScanningDefaultSetupLanguage.Javascript => "javascript",
                CodeScanningDefaultSetupLanguage.JavascriptTypescript => "javascript-typescript",
                CodeScanningDefaultSetupLanguage.Python => "python",
                CodeScanningDefaultSetupLanguage.Ruby => "ruby",
                CodeScanningDefaultSetupLanguage.Swift => "swift",
                CodeScanningDefaultSetupLanguage.Typescript => "typescript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupLanguage? ToEnum(string value)
        {
            return value switch
            {
                "c-cpp" => CodeScanningDefaultSetupLanguage.CCpp,
                "csharp" => CodeScanningDefaultSetupLanguage.Csharp,
                "go" => CodeScanningDefaultSetupLanguage.Go,
                "java-kotlin" => CodeScanningDefaultSetupLanguage.JavaKotlin,
                "javascript" => CodeScanningDefaultSetupLanguage.Javascript,
                "javascript-typescript" => CodeScanningDefaultSetupLanguage.JavascriptTypescript,
                "python" => CodeScanningDefaultSetupLanguage.Python,
                "ruby" => CodeScanningDefaultSetupLanguage.Ruby,
                "swift" => CodeScanningDefaultSetupLanguage.Swift,
                "typescript" => CodeScanningDefaultSetupLanguage.Typescript,
                _ => null,
            };
        }
    }
}