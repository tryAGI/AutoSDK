//HintName: G.Models.CodeScanningDefaultSetupUpdateLanguages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningDefaultSetupUpdateLanguages
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="c-cpp")]
        CCpp,
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
        [global::System.Runtime.Serialization.EnumMember(Value="java-kotlin")]
        JavaKotlin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="javascript-typescript")]
        JavascriptTypescript,
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
        public static CodeScanningDefaultSetupUpdateLanguages? ToEnum(string value)
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
                _ => null,
            };
        }
    }
}