//HintName: G.Models.CodeScanningDefaultSetupLanguages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CodeScanningDefaultSetupLanguages
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
        Typescript,
        /// <summary>
        /// 
        /// </summary>
        Swift,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningDefaultSetupLanguagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupLanguages value)
        {
            return value switch
            {
                CodeScanningDefaultSetupLanguages.CCpp => "c-cpp",
                CodeScanningDefaultSetupLanguages.Csharp => "csharp",
                CodeScanningDefaultSetupLanguages.Go => "go",
                CodeScanningDefaultSetupLanguages.JavaKotlin => "java-kotlin",
                CodeScanningDefaultSetupLanguages.JavascriptTypescript => "javascript-typescript",
                CodeScanningDefaultSetupLanguages.Javascript => "javascript",
                CodeScanningDefaultSetupLanguages.Python => "python",
                CodeScanningDefaultSetupLanguages.Ruby => "ruby",
                CodeScanningDefaultSetupLanguages.Typescript => "typescript",
                CodeScanningDefaultSetupLanguages.Swift => "swift",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupLanguages? ToEnum(string value)
        {
            return value switch
            {
                "c-cpp" => CodeScanningDefaultSetupLanguages.CCpp,
                "csharp" => CodeScanningDefaultSetupLanguages.Csharp,
                "go" => CodeScanningDefaultSetupLanguages.Go,
                "java-kotlin" => CodeScanningDefaultSetupLanguages.JavaKotlin,
                "javascript-typescript" => CodeScanningDefaultSetupLanguages.JavascriptTypescript,
                "javascript" => CodeScanningDefaultSetupLanguages.Javascript,
                "python" => CodeScanningDefaultSetupLanguages.Python,
                "ruby" => CodeScanningDefaultSetupLanguages.Ruby,
                "typescript" => CodeScanningDefaultSetupLanguages.Typescript,
                "swift" => CodeScanningDefaultSetupLanguages.Swift,
                _ => null,
            };
        }
    }
}