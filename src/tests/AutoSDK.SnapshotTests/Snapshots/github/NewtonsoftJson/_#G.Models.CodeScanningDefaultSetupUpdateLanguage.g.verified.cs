//HintName: G.Models.CodeScanningDefaultSetupUpdateLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeScanningDefaultSetupUpdateLanguage
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